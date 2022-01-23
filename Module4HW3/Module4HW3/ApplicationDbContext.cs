﻿using Microsoft.EntityFrameworkCore;
using Module4HW3.Configurations;
using Module4HW3.Entities;
using Module4HW3.EntityConfigurations;

namespace Module4HW3;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Office>? Offices { get; set; }
    public DbSet<Title>? Titles { get; set; }
    public DbSet<EmployeeProject>? EmployeeProjects { get; set; }
    public DbSet<Project>? Projects { get; set; }
    public DbSet<Client>? Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
        modelBuilder.ApplyConfiguration(new OfficeConfiguration());
        modelBuilder.ApplyConfiguration(new TitleConfiguration());
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
    }
}