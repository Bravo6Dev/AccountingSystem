using Domain.DTOs.CashBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Employees
{
    public class NewEmployee
    {
        public string Username { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public decimal Salary  { get; set; }
        public int PermissionId { get; set; }
    }
}
