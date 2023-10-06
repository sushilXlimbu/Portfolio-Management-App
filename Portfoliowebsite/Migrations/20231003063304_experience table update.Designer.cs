﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfoliowebsite.Data;

#nullable disable

namespace Portfoliowebsite.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20231003063304_experience table update")]
    partial class experiencetableupdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Portfoliowebsite.Models.AboutModel", b =>
                {
                    b.Property<Guid>("Aboutid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Aboutid");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("About");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.AwardAndCertificationModel", b =>
                {
                    b.Property<Guid>("AwardAndCertification")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AwardTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AwardAndCertification");

                    b.HasIndex("User_Id");

                    b.ToTable("AwardAndCertifications");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.EducationModel", b =>
                {
                    b.Property<Guid>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EducationField")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Gpa")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("endDateonly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startDateonly")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationId");

                    b.HasIndex("User_Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ExperienceModel", b =>
                {
                    b.Property<Guid>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("endDateonly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startDateonly")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperienceId");

                    b.HasIndex("User_Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.IntrestModel", b =>
                {
                    b.Property<Guid>("IntrestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IntrestDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IntrestId");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("Intrests");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ProfilePic", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PictureId"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PictureId");

                    b.HasIndex("User_Id");

                    b.ToTable("ProfileImage");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ProgrammingLanguageModel", b =>
                {
                    b.Property<Guid>("ProgrammingLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProgrammingLanguageId");

                    b.HasIndex("User_Id");

                    b.ToTable("ProgrammingLanguages");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.SocialMediaModel", b =>
                {
                    b.Property<Guid>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SocialMediaId");

                    b.HasIndex("User_Id");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.TitleModel", b =>
                {
                    b.Property<Guid>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AwardTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntrestTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TitleId");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.User", b =>
                {
                    b.Property<Guid>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.WorkFLowModel", b =>
                {
                    b.Property<Guid>("WorkflowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkFlowList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkflowId");

                    b.HasIndex("User_Id");

                    b.ToTable("WorkFLows");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.AboutModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithOne("About")
                        .HasForeignKey("Portfoliowebsite.Models.AboutModel", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.AwardAndCertificationModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("AwardAndCertificationList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.EducationModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("EducationList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ExperienceModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("ExperienceList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.IntrestModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithOne("Intrest")
                        .HasForeignKey("Portfoliowebsite.Models.IntrestModel", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ProfilePic", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.ProgrammingLanguageModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("ProgrammingLanguageList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.SocialMediaModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("SocialMediaList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.TitleModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithOne("Title")
                        .HasForeignKey("Portfoliowebsite.Models.TitleModel", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.WorkFLowModel", b =>
                {
                    b.HasOne("Portfoliowebsite.Models.User", "Users")
                        .WithMany("WorkFLowList")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Portfoliowebsite.Models.User", b =>
                {
                    b.Navigation("About")
                        .IsRequired();

                    b.Navigation("AwardAndCertificationList");

                    b.Navigation("EducationList");

                    b.Navigation("ExperienceList");

                    b.Navigation("Intrest")
                        .IsRequired();

                    b.Navigation("ProgrammingLanguageList");

                    b.Navigation("SocialMediaList");

                    b.Navigation("Title")
                        .IsRequired();

                    b.Navigation("WorkFLowList");
                });
#pragma warning restore 612, 618
        }
    }
}
