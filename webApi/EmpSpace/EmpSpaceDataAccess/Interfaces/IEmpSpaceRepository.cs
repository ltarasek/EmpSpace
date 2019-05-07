using EmpSpaceDataAccess.DTO;
using EmpSpaceDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSpaceDataAccess.Interfaces
{
    public interface IEmpSpaceRepository
    {
        List<BaseEmployeeDto> GetEmployees();
        Employee GetEmployee(int id);
    }
}
