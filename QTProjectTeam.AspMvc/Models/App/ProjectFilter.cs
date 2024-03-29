﻿//@GeneratedCode
namespace QTProjectTeam.AspMvc.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class ProjectFilter : Models.View.IFilterModel
    {
        ///
        /// Generated by the generator
        ///
        static ProjectFilter()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public ProjectFilter()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        
        ///
        /// Generated by the generator
        ///
        public System.String? Designation
        { get; set; }
        
        ///
        /// Generated by the generator
        ///
        public System.String? Description
        { get; set; }
        ///
        /// Generated by the generator
        ///
        public bool HasEntityValue => Designation != null || Description != null;
        private bool show = true;
        ///
        /// Generated by the generator
        ///
        public bool Show => show;
        ///
        /// Generated by the generator
        ///
        public string CreateEntityPredicate()
        {
            var result = new System.Text.StringBuilder();
            
            if (Designation != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Designation != null && Designation.Contains(\"{Designation}\"))");
            }
            if (Description != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Description != null && Description.Contains(\"{Description}\"))");
            }
            return result.ToString();
        }
        ///
        /// Generated by the generator
        ///
        public override string ToString()
        {
            System.Text.StringBuilder sb = new();
            if (string.IsNullOrEmpty(Designation) == false)
{
sb.Append($"Designation: {Designation} ");
}
if (string.IsNullOrEmpty(Description) == false)
{
sb.Append($"Description: {Description} ");
}
            return sb.ToString();
        }
    }
}
