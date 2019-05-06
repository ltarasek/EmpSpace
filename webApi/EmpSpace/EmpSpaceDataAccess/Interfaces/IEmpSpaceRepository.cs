using EmpSpaceDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSpaceDataAccess.Interfaces
{
    public interface IEmpSpaceRepository
    {
        List<Employee> GetEmployees();
        
    }
}
