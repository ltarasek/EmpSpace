using EmpSpaceDataAccess.Interfaces;
using EmpSpaceDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using EmpSpaceDataAccess.Models;
using EmpSpaceDataAccess.DTO;

namespace EmpSpaceDataAccess.Repository
{
    public class EmpSpaceRepository : IEmpSpaceRepository
    {
        public List<BaseEmployeeDto> GetEmployees()
        {
            using (var empContext = new EmpSpaceContext())
            {
                return empContext.Employee.Select(emp => new BaseEmployeeDto() {
                    Id = emp.Id,
                    Name = emp.Name,
                    LastName = emp.LastName }).ToList();
            }
        }

    }
}
