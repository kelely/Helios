using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Helios.Authorization.Users;

namespace Helios.Membership.Customers
{
    public class CustomerManager : HeliosMembershipDomainServiceBase, ICustomerManager
    {
        private readonly IRepository<Customer, long> _customerRepository;
        private readonly UserManager _userManager;

        public CustomerManager(
            IRepository<Customer, long> customerRepository,
            UserManager userManager)
        {
            _customerRepository = customerRepository;
            _userManager = userManager;
        }

        /// <summary>
        /// 创建会员的同时新增会员对应的用户
        /// </summary>
        /// <returns></returns>
        public async Task<int> CreateWithCustomerUserAsync(
            string mobileNumber,
            string suname,
            string username
            )
        {
            int newTenantId;
            long newAdminId;

            _userManager.c

            await CheckEditionAsync(editionId, isInTrialPeriod);

            using (var uow = _unitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                // 创建租户
                var tenant = new Tenant(tenancyName, name)
                {
                    IsActive = isActive,
                    EditionId = editionId,
                    SubscriptionEndDateUtc = subscriptionEndDate?.ToUniversalTime(),
                    IsInTrialPeriod = isInTrialPeriod,
                    ConnectionString = connectionString.IsNullOrWhiteSpace() ? null : SimpleStringCipher.Instance.Encrypt(connectionString)
                };

                await CreateAsync(tenant);
                await _unitOfWorkManager.Current.SaveChangesAsync(); // 保存后可获得新租户的Id

                // 创建租户的数据库
                _abpZeroDbMigrator.CreateOrMigrateForTenant(tenant);

                // 以下的实体需要进行租户隔离，所以需要改变事务的租户Id
                using (_unitOfWorkManager.Current.SetTenantId(tenant.Id))
                {
                    // 给新租户添加静态角色
                    CheckErrors(await _roleManager.CreateStaticRoles(tenant.Id));
                    await _unitOfWorkManager.Current.SaveChangesAsync(); //To get static role ids

                    // 赋予 Admin 角色所有操作权限
                    var adminRole = _roleManager.Roles.Single(r => r.Name == StaticRoleNames.Tenants.Admin);
                    await _roleManager.GrantAllPermissionsAsync(adminRole);

                    // 设置 User 角色为默认角色
                    var userRole = _roleManager.Roles.Single(r => r.Name == StaticRoleNames.Tenants.User);
                    userRole.IsDefault = true;
                    CheckErrors(await _roleManager.UpdateAsync(userRole));

                    // 创建管理员用户
                    if (adminPassword.IsNullOrEmpty())
                    {
                        adminPassword = User.CreateRandomPassword();
                    }

                    var adminUser = User.CreateTenantAdminUser(tenant.Id, adminEmailAddress);
                    adminUser.Password = _passwordHasher.HashPassword(adminUser, adminPassword);
                    adminUser.ShouldChangePasswordOnNextLogin = shouldChangePasswordOnNextLogin;
                    adminUser.IsActive = true;

                    CheckErrors(await _userManager.CreateAsync(adminUser));
                    await _unitOfWorkManager.Current.SaveChangesAsync(); //To get admin user's id

                    // 设置管理员用户的 Admin 角色
                    CheckErrors(await _userManager.AddToRoleAsync(adminUser, adminRole.Name));

                    // 给管理员用户发送欢迎消息
                    await _appNotifier.WelcomeToTheApplicationAsync(adminUser);

                    // 发送用户账号激活邮件
                    if (sendActivationEmail)
                    {
                        adminUser.SetNewEmailConfirmationCode();
                        await _userEmailer.SendEmailActivationLinkAsync(adminUser, emailActivationLink, adminPassword);
                    }

                    await _unitOfWorkManager.Current.SaveChangesAsync();

                    await _demoDataBuilder.BuildForAsync(tenant);

                    newTenantId = tenant.Id;
                    newAdminId = adminUser.Id;
                }

                await uow.CompleteAsync();
            }

            //Used a second UOW since UOW above sets some permissions and _notificationSubscriptionManager.SubscribeToAllAvailableNotificationsAsync needs these permissions to be saved.
            using (var uow = _unitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                using (_unitOfWorkManager.Current.SetTenantId(newTenantId))
                {
                    await _notificationSubscriptionManager.SubscribeToAllAvailableNotificationsAsync(new UserIdentifier(newTenantId, newAdminId));
                    await _unitOfWorkManager.Current.SaveChangesAsync();
                    await uow.CompleteAsync();
                }
            }

            return newTenantId;
        }
    }
}
