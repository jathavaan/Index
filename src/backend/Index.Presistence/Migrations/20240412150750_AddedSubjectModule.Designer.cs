﻿// <auto-generated />
using System;
using Index.Presistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Index.Presistence.Migrations
{
    [DbContext(typeof(IndexDbContext))]
    [Migration("20240412150750_AddedSubjectModule")]
    partial class AddedSubjectModule
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 4, 12, 17, 7, 50, 290, DateTimeKind.Local).AddTicks(7625));

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

                    b.ToTable("ReportCard", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCardSubject", b =>
                {
                    b.Property<int>("ReportCardId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("ReportCardId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ReportCardSubject", "sub");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Credit")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("Id");

                    b.ToTable("Subject", "sub");
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
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Index.Domain.Entities.SubjectModule.Subject", "Subject")
                        .WithMany("ReportCardSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportCard");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.ReportCard", b =>
                {
                    b.Navigation("ReportCardSubjects");
                });

            modelBuilder.Entity("Index.Domain.Entities.SubjectModule.Subject", b =>
                {
                    b.Navigation("ReportCardSubjects");
                });

            modelBuilder.Entity("Index.Domain.Entities.UserModule.UserProfile", b =>
                {
                    b.Navigation("ReportCards");
                });
#pragma warning restore 612, 618
        }
    }
}
