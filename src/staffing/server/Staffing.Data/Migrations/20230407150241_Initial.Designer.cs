﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Staffing.Data;

#nullable disable

namespace Staffing.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230407150241_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Staffing.Models.Entities.Approval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId")
                        .IsUnique();

                    b.ToTable("Approval", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.ApprovalT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessTId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessTId")
                        .IsUnique();

                    b.ToTable("ApprovalT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attachment", (string)null);

                    b.HasDiscriminator<string>("Type").HasValue("attachment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Staffing.Models.Entities.Deadline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId")
                        .IsUnique();

                    b.ToTable("Deadline", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.DeadlineT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.Property<int>("Months")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessTId")
                        .HasColumnType("int");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessTId")
                        .IsUnique();

                    b.ToTable("DeadlineT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("Note", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkflowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId")
                        .IsUnique()
                        .HasFilter("[WorkflowId] IS NOT NULL");

                    b.ToTable("Package", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("WorkflowId");

                    b.ToTable("Process", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.ProcessT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkflowTId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("WorkflowTId");

                    b.ToTable("ProcessT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Key")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registration", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Requirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("Requirement", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.RequirementT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessTId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessTId");

                    b.ToTable("RequirementT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.Property<string>("OriginType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.ToTable("Resource", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Concur")
                        .HasColumnType("bit");

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.HasIndex("RoleId");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.ReviewT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessTId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessTId");

                    b.HasIndex("RoleId");

                    b.ToTable("ReviewT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Key")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PackageId")
                        .IsUnique();

                    b.HasIndex("RegistrationId");

                    b.ToTable("Token", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workflow", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.WorkflowT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkflowT", (string)null);
                });

            modelBuilder.Entity("Staffing.Models.Entities.PackageAttachment", b =>
                {
                    b.HasBaseType("Staffing.Models.Entities.Attachment");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.HasIndex("PackageId");

                    b.HasDiscriminator().HasValue("package");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ProcessAttachment", b =>
                {
                    b.HasBaseType("Staffing.Models.Entities.Attachment");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasIndex("ProcessId");

                    b.HasDiscriminator().HasValue("process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.TokenAttachment", b =>
                {
                    b.HasBaseType("Staffing.Models.Entities.Attachment");

                    b.Property<int>("TokenId")
                        .HasColumnType("int");

                    b.HasIndex("TokenId");

                    b.HasDiscriminator().HasValue("token");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Approval", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithOne("Approval")
                        .HasForeignKey("Staffing.Models.Entities.Approval", "ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ApprovalT", b =>
                {
                    b.HasOne("Staffing.Models.Entities.ProcessT", "ProcessT")
                        .WithOne("ApprovalT")
                        .HasForeignKey("Staffing.Models.Entities.ApprovalT", "ProcessTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProcessT");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Deadline", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithOne("Deadline")
                        .HasForeignKey("Staffing.Models.Entities.Deadline", "ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.DeadlineT", b =>
                {
                    b.HasOne("Staffing.Models.Entities.ProcessT", "ProcessT")
                        .WithOne("DeadlineT")
                        .HasForeignKey("Staffing.Models.Entities.DeadlineT", "ProcessTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProcessT");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Note", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithMany("Notes")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Package", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Workflow", "Workflow")
                        .WithOne("Package")
                        .HasForeignKey("Staffing.Models.Entities.Package", "WorkflowId");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Process", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Role", "Role")
                        .WithMany("Processes")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staffing.Models.Entities.Workflow", "Workflow")
                        .WithMany("Processes")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ProcessT", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Role", "Role")
                        .WithMany("ProcessTs")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staffing.Models.Entities.WorkflowT", "WorkflowT")
                        .WithMany("ProcessTs")
                        .HasForeignKey("WorkflowTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("WorkflowT");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Requirement", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithMany("Requirements")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.RequirementT", b =>
                {
                    b.HasOne("Staffing.Models.Entities.ProcessT", "ProcessT")
                        .WithMany("RequirementTs")
                        .HasForeignKey("ProcessTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProcessT");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Resource", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Package", "Package")
                        .WithMany("Resources")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Review", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithMany("Reviews")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staffing.Models.Entities.Role", "Role")
                        .WithMany("Reviews")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Process");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ReviewT", b =>
                {
                    b.HasOne("Staffing.Models.Entities.ProcessT", "ProcessT")
                        .WithMany("ReviewTs")
                        .HasForeignKey("ProcessTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staffing.Models.Entities.Role", "Role")
                        .WithMany("ReviewTs")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProcessT");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Token", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Package", "Package")
                        .WithOne("Token")
                        .HasForeignKey("Staffing.Models.Entities.Token", "PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staffing.Models.Entities.Registration", "Registration")
                        .WithMany("Tokens")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Staffing.Models.Entities.UserRole", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Staffing.Models.Entities.PackageAttachment", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Package", "Package")
                        .WithMany("Attachments")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ProcessAttachment", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Process", "Process")
                        .WithMany("Attachments")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Staffing.Models.Entities.TokenAttachment", b =>
                {
                    b.HasOne("Staffing.Models.Entities.Token", "Token")
                        .WithMany("Attachments")
                        .HasForeignKey("TokenId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Token");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Package", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Resources");

                    b.Navigation("Token");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Process", b =>
                {
                    b.Navigation("Approval");

                    b.Navigation("Attachments");

                    b.Navigation("Deadline");

                    b.Navigation("Notes");

                    b.Navigation("Requirements");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Staffing.Models.Entities.ProcessT", b =>
                {
                    b.Navigation("ApprovalT");

                    b.Navigation("DeadlineT");

                    b.Navigation("RequirementTs");

                    b.Navigation("ReviewTs");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Registration", b =>
                {
                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Role", b =>
                {
                    b.Navigation("ProcessTs");

                    b.Navigation("Processes");

                    b.Navigation("ReviewTs");

                    b.Navigation("Reviews");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Token", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("Staffing.Models.Entities.Workflow", b =>
                {
                    b.Navigation("Package");

                    b.Navigation("Processes");
                });

            modelBuilder.Entity("Staffing.Models.Entities.WorkflowT", b =>
                {
                    b.Navigation("ProcessTs");
                });
#pragma warning restore 612, 618
        }
    }
}