using Azure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Entity;
using TodoConsoleApp.Models;

namespace TodoConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Add();
            // Update();
            GetData();
        }
        static void Add()
        {
            using var dbContext = new TodoDbContext();
            using var transaction = dbContext.Database.BeginTransaction();
            try
            {
                var emp = dbContext.Add(new Employee
                {
                    Name = "Jeevan KC",
                    Phone = "+97798611111",
                    Address = new Address
                    {
                        AddressLine1 = "AddressLine1",
                        AddressLive2 = "AddressLine2",
                        City = "Ghorahi"
                    }
                });

                dbContext.SaveChanges();
                //dbContext.Addresses.Add(new Address() { AddressLine1 = "Ghorahi-17" });
                //dbContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        static void Update()
        {
            var dbContext = new TodoDbContext();
            var employee = new Employee()
            {
                EmployeeId = 8,
                Name = "Udpated Name",
                Phone = "+97798611111",
                Address = new Address
                {
                    EmployeeId = 8,
                    AddressLine1 = "Updated AddressLine1",
                    AddressLive2 = "Updated AddressLine2",
                    City = "Updated Ghorahi"
                }
            };
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
        }

        static void GetData()
        {
            var dbContext = new TodoDbContext();

            Console.WriteLine("Enter the page number-1,2,3,4,5");
            int pageNumber = 0;
            if (int.TryParse(Console.ReadLine(), out pageNumber))
            {
                if (pageNumber >= 1 && pageNumber <= 5)
                {
                    int pageSize = 4;
                    var result = dbContext.Employees.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                    Console.WriteLine("Displaying page :" + pageNumber);
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.EmployeeId + "\t" + item.Name + "\t" + item.Phone);
                    }
                }
                else
                {
                    Console.WriteLine(@"Page number must be integer between 1 and 5");
                }
            }
            else
            {
                Console.WriteLine(@"Page number must be integer between 1 and 5");
            }
        }
    }
}
