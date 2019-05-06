
using System;
using System.Collections.Generic;

namespace EmpSpaceDataAccess.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }

        public DateTime BirthDate { get; set; }
        public List<Position> Position { get; set; }
  
        public int SupervisorId { get; set; }
    }
}