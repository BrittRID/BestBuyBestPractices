using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository : DepartmentRepository
    {
        private readonly IDbConnection _connection;
        

        //Constructor
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            var depos = _connection.Query<Department>("SELECT * FROM Departments;");

            return depos;
        }


        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
            new { departmentName = newDepartmentName });
        }
    }
}
