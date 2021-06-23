using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DomainModel
{
    public class EmployeeDomain
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}