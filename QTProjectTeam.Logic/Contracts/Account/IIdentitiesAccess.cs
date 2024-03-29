﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTProjectTeam.Logic.Contracts.Account
{
    public partial interface IIdentitiesAccess<T> : IDataAccess<T>
    {
        public Task AddRoleAsync(IdType id, IdType roleId);
        public Task RemoveRoleAsync(IdType id, IdType roleId);
    }
}
#endif
//MdEnd
