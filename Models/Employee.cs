namespace EmployeeCRUDApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }      // Primary key, auto-increment
        public string? Name { get; set; }         // Employee's full name
        public string? Position { get; set; }     // Job title
        public string? Department { get; set; }   // Department name
        public decimal Salary { get; set; }      // Salary amount
    }
}
