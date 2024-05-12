﻿// <auto-generated />
using System;
using Index.Presistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Index.Presistence.Migrations
{
    [DbContext(typeof(IndexDbContext))]
    partial class IndexDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 12, 17, 20, 18, 972, DateTimeKind.Local).AddTicks(7319));

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentGroupId");

                    b.ToTable("Assignments", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.AssignmentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentsRequired")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(690));

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("TotalAssignments")
                        .HasColumnType("int");

                    b.Property<string>("UserProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectCode");

                    b.HasIndex("UserProfileId");

                    b.ToTable("AssignmentGroups", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 12, 17, 20, 18, 973, DateTimeKind.Local).AddTicks(8747));

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("ReportCards", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCardSubject", b =>
                {
                    b.Property<int>("ReportCardId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("ReportCardId", "SubjectCode", "Year");

                    b.HasIndex("SubjectCode");

                    b.ToTable("ReportCardSubjects", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("StudyPlans", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlanRestriction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("RequiredCredits")
                        .HasColumnType("float");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("StudyPlanId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectType")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudyPlanId");

                    b.ToTable("StudyPlanRestrictions", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlanSubject", b =>
                {
                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("StudyPlanId")
                        .HasColumnType("int");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("SubjectCode", "StudyPlanId");

                    b.HasIndex("StudyPlanId");

                    b.ToTable("StudyPlanSubjects", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Subject", b =>
                {
                    b.Property<string>("SubjectCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<double>("Credits")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("SubjectCode");

                    b.ToTable("Subjects", "sub");

                    b.HasData(
                        new
                        {
                            SubjectCode = "EXPH0300",
                            Credits = 7.5,
                            Name = "Examen philosophicum for Science and Technology",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "HMS0002",
                            Credits = 0.0,
                            Name = "Health, Safety and Environment (HSE) course for 1st year students",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "IT2805",
                            Credits = 7.5,
                            Name = "Web Technologies",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4231",
                            Credits = 7.5,
                            Name = "Applied Geomatics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4236",
                            Credits = 7.5,
                            Name = "Theoretical Geomatics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4240",
                            Credits = 7.5,
                            Name = "Geographic Information Handling 1, Basic Course",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4250",
                            Credits = 7.5,
                            Name = "Geographic Information Handling 2, Basic Course",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4251",
                            Credits = 7.5,
                            Name = "Programming in Geomatics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TBA4256",
                            Credits = 7.5,
                            Name = "3D Digital Modelling",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TFY4115",
                            Credits = 7.5,
                            Name = "Physics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TEP4100",
                            Credits = 7.5,
                            Name = "Fluid Mechanics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TEP4225",
                            Credits = 7.5,
                            Name = "Energy and Environment",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4100",
                            Credits = 7.5,
                            Name = "Object-Oriented Programming",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4110",
                            Credits = 7.5,
                            Name = "Information Technology, Introduction",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4120",
                            Credits = 7.5,
                            Name = "Algorithms and Data Structures",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4140",
                            Credits = 7.5,
                            Name = "Software Engineering",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4145",
                            Credits = 7.5,
                            Name = "Data Modelling, Databases, and Database Management Systems",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TDT4173",
                            Credits = 7.5,
                            Name = "Machine Learning",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TKT4116",
                            Credits = 7.5,
                            Name = "Mechanics 1",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TKT4122",
                            Credits = 7.5,
                            Name = "Mechanics 2",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4100",
                            Credits = 7.5,
                            Name = "Calculus 1",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4105",
                            Credits = 7.5,
                            Name = "Calculus 2",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4115",
                            Credits = 7.5,
                            Name = "Mathematics 3 - Linear Algebra",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4130",
                            Credits = 7.5,
                            Name = "Mathematics 4N - Differential Equations and Fourier Analysis",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4140",
                            Credits = 7.5,
                            Name = "Discrete Mathematics",
                            Type = 0
                        },
                        new
                        {
                            SubjectCode = "TMA4240",
                            Credits = 7.5,
                            Name = "Statistics",
                            Type = 0
                        });
                });

            modelBuilder.Entity("Index.Domain.Entities.UserModule.UserProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Assignment", b =>
                {
                    b.HasOne("Index.Domain.Entities.SubjectModule.AssignmentGroup", "AssignmentGroup")
                        .WithMany("Assignments")
                        .HasForeignKey("AssignmentGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignmentGroup");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.AssignmentGroup", b =>
                {
                    b.HasOne("Index.Domain.Entities.SubjectModule.Subject", "Subject")
                        .WithMany("AssignmentGroups")
                        .HasForeignKey("SubjectCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Index.Domain.Entities.UserModule.UserProfile", "UserProfile")
                        .WithMany("AssignmentGroups")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCard", b =>
                {
                    b.HasOne("Index.Domain.Entities.UserModule.UserProfile", "UserProfile")
                        .WithMany("ReportCards")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCardSubject", b =>
                {
                    b.HasOne("Index.Domain.Entities.SubjectModule.ReportCard", "ReportCard")
                        .WithMany("ReportCardSubjects")
                        .HasForeignKey("ReportCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Index.Domain.Entities.SubjectModule.Subject", "Subject")
                        .WithMany("ReportCardSubjects")
                        .HasForeignKey("SubjectCode")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("ReportCard");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlan", b =>
                {
                    b.HasOne("Index.Domain.Entities.UserModule.UserProfile", "UserProfile")
                        .WithMany("StudyPlans")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlanRestriction", b =>
                {
                    b.HasOne("Index.Domain.Entities.SubjectModule.StudyPlan", "StudyPlan")
                        .WithMany("StudyPlanRestrictions")
                        .HasForeignKey("StudyPlanId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("StudyPlan");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlanSubject", b =>
                {
                    b.HasOne("Index.Domain.Entities.SubjectModule.StudyPlan", "StudyPlan")
                        .WithMany("StudyPlanSubjects")
                        .HasForeignKey("StudyPlanId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Index.Domain.Entities.SubjectModule.Subject", "Subject")
                        .WithMany("StudyPlanSubjects")
                        .HasForeignKey("SubjectCode")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("StudyPlan");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.AssignmentGroup", b =>
                {
                    b.Navigation("Assignments");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCard", b =>
                {
                    b.Navigation("ReportCardSubjects");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.StudyPlan", b =>
                {
                    b.Navigation("StudyPlanRestrictions");

                    b.Navigation("StudyPlanSubjects");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Subject", b =>
                {
                    b.Navigation("AssignmentGroups");

                    b.Navigation("ReportCardSubjects");

                    b.Navigation("StudyPlanSubjects");
                });

            modelBuilder.Entity("Index.Domain.Entities.UserModule.UserProfile", b =>
                {
                    b.Navigation("AssignmentGroups");

                    b.Navigation("ReportCards");

                    b.Navigation("StudyPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
