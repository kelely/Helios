namespace Helios.Membership.Authorization.Roles
{
    public static class StaticRoleNames
    {
        //public static class Host
        //{
        //    public const string Admin = "Admin";
        //}

        public static class Tenants
        {
            /// <summary>
            /// 角色定义:客户主管、会籍顾问
            /// </summary>
            public const string CustomerSupervisor = "CustomerSupervisor";

            /// <summary>
            /// 角色定义:客户、会员
            /// </summary>
            public const string Customer = "Customer";
        }
    }
}