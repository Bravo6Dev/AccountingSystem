using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IServiceManager
    {
        public IEmployeeService EmployeeService { get; }
        public IPermissionService PermissionService { get; }
        public ICashBoxService CashBoxService { get; }
    }
}
