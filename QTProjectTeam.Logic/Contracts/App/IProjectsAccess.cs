﻿//@GeneratedCode
namespace QTProjectTeam.Logic.Contracts.App
{
    ///
    /// Generated by the generator
    ///
    public partial interface IProjectsAccess<T> : Contracts.IDataAccess<T>
    {
        Task<Models.App.Project?> AddMemberAsync(int projectId, int memberId);
    }
}
