using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
    public interface DepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();

        void InsertDepartment(string newDepartmentName);
    
    }


}
