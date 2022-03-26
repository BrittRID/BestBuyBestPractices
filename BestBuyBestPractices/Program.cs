using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace BestBuyBestPractices
{
    class Program
    {


        static void Main(string[] args)
        {

           #region Configuration
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            #endregion


            IDbConnection connection = new MySqlConnection(connString);

            var repo = new DapperProductRepository(connection);

            repo.CreateProduct("Department", 20, 10);
            var products = repo.GetAllProducts();

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }








            //    DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);


            //    Console.WriteLine("Hello user, here are the current departments");
            //    Console.WriteLine("Please press enter....");
            //    Console.ReadLine();

            //   var depos =  repo.GetAllDepartments();
            //   Print(depos);


            //    Console.WriteLine("Do you want to add a Department");
            //    string userResponse = Console.ReadLine();

            //   if (userResponse.ToLower() == "yes")
            //    {
            //        Console.WriteLine("What is the name of your new Department");
            //        userResponse = Console.ReadLine();

            //        repo.InsertDepartment(userResponse);
            //        Print(repo.GetAllDepartments());
            //    }

            //    Console.WriteLine("Have a great day.");
            //}
            //private static void Print(IEnumerable<Department>depos)
            //{
            //    foreach(var depo in depos)
            //    {
            //        Console.WriteLine($"ID: {depo.DepartmentID} Name: {depo.Name}");
            //    }
        }
    }
}
