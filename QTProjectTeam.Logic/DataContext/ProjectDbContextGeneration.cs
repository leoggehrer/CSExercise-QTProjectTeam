﻿//@GeneratedCode
namespace QTProjectTeam.Logic.DataContext
{
    ///
    /// Generated by the generator
    ///
    partial class ProjectDbContext
    {
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Member>? MemberSet{ get; set; }
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Project>? ProjectSet{ get; set; }
        
        ///
        /// Generated by the generator
        ///
        partial void GetGeneratorDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.EntityObject
        {
            if (typeof(E) == typeof(Entities.App.Member))
            {
                dbSet = MemberSet as DbSet<E>;
                handled = true;
            }
            else if (typeof(E) == typeof(Entities.App.Project))
            {
                dbSet = ProjectSet as DbSet<E>;
                handled = true;
            }
        }
    }
}
