using System;
using Abp.Authorization.Users;

// ReSharper disable once CheckNamespace
namespace Helios.Membership
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";
        public const string EmptyPassword = "[EMPTY]";
        public const int MaxPhoneNumberLength = 32;
    }
}
