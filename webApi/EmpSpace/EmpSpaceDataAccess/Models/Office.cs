using System;
using System.Collections.Generic;


namespace EmpSpaceDataAccess.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
