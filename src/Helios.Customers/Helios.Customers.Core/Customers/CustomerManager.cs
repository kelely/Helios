using System;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Helios.Authorization.Users;

namespace Helios.Customers
{
    public class CustomerManager : HeliosCustomersDomainServiceBase, ICustomerManager
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
            throw new NotImplementedException();
        }
    }
}
