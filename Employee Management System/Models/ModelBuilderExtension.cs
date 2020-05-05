using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Tega",
                    Department = Dept.IT,
                    Email = "tega@gmail.com"

                },
                new Employee
                {
                    Id = 2,
                    Name = "Tega1",
                    Department = Dept.IT,
                    Email = "tega1@gmail.com"

                }
                );
        }
    }
}
