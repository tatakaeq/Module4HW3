﻿namespace Module4HW3.Entities;

public class Project
{
    public int ProjectId { get; set; }
    public string? Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartedDate { get; set; }
    public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    public int ClientId { get; set; }
    public Client? Client { get; set; }
}