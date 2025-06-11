using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Employees
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public DateTime CreateDate { get; set; }
        public string Permission { get; set; } = string.Empty;
        public string CashBoxName { get; set; } = string.Empty;
    }
}
