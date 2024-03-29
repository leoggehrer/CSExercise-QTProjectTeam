﻿//@GeneratedCode
namespace QTProjectTeam.WebApi.Controllers.App
{
    ///
    /// Generated by the generator
    ///
    public sealed partial class ProjectsController : Controllers.GenericController<QTProjectTeam.Logic.Models.App.Project, QTProjectTeam.WebApi.Models.App.ProjectEdit, QTProjectTeam.WebApi.Models.App.Project>
    {
        ///
        /// Generated by the generator
        ///
        static ProjectsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public ProjectsController(QTProjectTeam.Logic.Contracts.App.IProjectsAccess<QTProjectTeam.Logic.Models.App.Project> other)
        : base(other)
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        protected override QTProjectTeam.WebApi.Models.App.Project ToOutModel(QTProjectTeam.Logic.Models.App.Project accessModel)
        {
            var handled = false;
            var result = default(QTProjectTeam.WebApi.Models.App.Project);
            BeforeToOutModel(accessModel, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = QTProjectTeam.WebApi.Models.App.Project.Create(accessModel);
            }
            AfterToOutModel(result);
            return result;
        }
        partial void BeforeToOutModel(QTProjectTeam.Logic.Models.App.Project accessModel, ref QTProjectTeam.WebApi.Models.App.Project? outModel, ref bool handled);
        partial void AfterToOutModel(QTProjectTeam.WebApi.Models.App.Project outModel);
    }
}
