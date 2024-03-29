﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON && LOGGING_ON
namespace QTProjectTeam.Logic.Entities.Logging
{
#if SQLITE_ON
    [Table("ActionLogs")]
#else
    [Table("ActionLogs", Schema = "logging")]
#endif
    internal partial class ActionLog : EntityObject
    {
        public IdType IdentityId { get; internal set; }
        public DateTime Time { get; internal set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; internal set; } = string.Empty;
        [Required]
        [MaxLength(128)]
        public string Action { get; internal set; } = string.Empty;
        [Required]
        public string Info { get; internal set; } = string.Empty;
    }
}
#endif
//MdEnd
