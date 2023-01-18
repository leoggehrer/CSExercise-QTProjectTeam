﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QTProjectTeam.Logic.DataContext;

#nullable disable

namespace QTProjectTeam.Logic.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("MemberProject", b =>
                {
                    b.Property<int>("MembersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MembersId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("MemberProject");
                });

            modelBuilder.Entity("QTProjectTeam.Logic.Entities.App.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("QTProjectTeam.Logic.Entities.App.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Designation")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MemberProject", b =>
                {
                    b.HasOne("QTProjectTeam.Logic.Entities.App.Member", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QTProjectTeam.Logic.Entities.App.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
