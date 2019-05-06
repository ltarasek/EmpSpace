using EmpSpaceDataAccess.Interfaces;
using EmpSpaceDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using EmpSpaceDataAccess.Models;

namespace EmpSpaceDataAccess.Repository
{
    public class EmpSpaceRepository : IEmpSpaceRepository
    {
        public List<Employee> GetEmployees()
        {
            using (var empContext = new EmpSpaceContext())
            {
                return empContext.Employee.Include(emp => emp.Position).ToList();
            }
        }

    }
}
