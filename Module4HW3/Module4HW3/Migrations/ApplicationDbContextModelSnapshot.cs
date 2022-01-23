﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4HW3;

#nullable disable

namespace Module4HW3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Module4HW3.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClientId");

                    b.ToTable("Client", (string)null);

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Country = "11111",
                            Email = "111111@1111.com",
                            PhoneNumber = "111111111111",
                            Title = "1"
                        },
                        new
                        {
                            ClientId = 2,
                            Country = "22222",
                            Email = "222222@2222.com",
                            PhoneNumber = "222222222222",
                            Title = "2"
                        },
                        new
                        {
                            ClientId = 3,
                            Country = "33333",
                            Email = "333333@3333.com",
                            PhoneNumber = "333333333333",
                            Title = "3"
                        },
                        new
                        {
                            ClientId = 4,
                            Country = "44444",
                            Email = "444444@4444.com",
                            PhoneNumber = "444444444444",
                            Title = "4"
                        },
                        new
                        {
                            ClientId = 5,
                            Country = "55555",
                            Email = "555555@5555.com",
                            PhoneNumber = "555555555555",
                            Title = "5"
                        });
                });

            modelBuilder.Entity("Module4HW3.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Module4HW3.Entities.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeProjectId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject", (string)null);
                });

            modelBuilder.Entity("Module4HW3.Entities.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficeId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Office", (string)null);
                });

            modelBuilder.Entity("Module4HW3.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project", (string)null);

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 100m,
                            ClientId = 1,
                            Name = "111",
                            StartedDate = new DateTime(2022, 1, 10, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7371)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 200m,
                            ClientId = 2,
                            Name = "222",
                            StartedDate = new DateTime(2022, 1, 11, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7408)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 300m,
                            ClientId = 3,
                            Name = "333",
                            StartedDate = new DateTime(2022, 1, 12, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7411)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 400m,
                            ClientId = 4,
                            Name = "444",
                            StartedDate = new DateTime(2022, 1, 13, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7413)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 500m,
                            ClientId = 5,
                            Name = "555",
                            StartedDate = new DateTime(2022, 1, 14, 20, 52, 47, 395, DateTimeKind.Local).AddTicks(7415)
                        });
                });

            modelBuilder.Entity("Module4HW3.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Title", (string)null);
                });

            modelBuilder.Entity("Module4HW3.Entities.Employee", b =>
                {
                    b.HasOne("Module4HW3.Entities.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW3.Entities.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Module4HW3.Entities.EmployeeProject", b =>
                {
                    b.HasOne("Module4HW3.Entities.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW3.Entities.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Module4HW3.Entities.Project", b =>
                {
                    b.HasOne("Module4HW3.Entities.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Module4HW3.Entities.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Module4HW3.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW3.Entities.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Module4HW3.Entities.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW3.Entities.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
