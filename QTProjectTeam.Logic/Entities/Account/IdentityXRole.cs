﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTProjectTeam.Logic.Entities.Account
{
    using QTProjectTeam.Logic.Contracts.Account;

#if SQLITE_ON
    [Table("IdentityXRoles")]
#else
    [Table("IdentityXRoles", Schema = "account")]
#endif
    [Index(nameof(IdentityId), nameof(RoleId), IsUnique = true)]
    public partial class IdentityXRole : VersionEntity, IIdentityXRole
    {
        public IdType IdentityId { get; set; }
        public IdType RoleId { get; set; }

        // Navigation properties
        public Identity? Identity { get; set; }
        public Role? Role { get; set; }
    }
}
#endif
//MdEnd
