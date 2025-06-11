using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repos
{
    public interface IUnitOfWork
    {
        public IEmployeeRepo EmployeeRepo { get; }
        public ICashBoxesRepo CashBoxesRepo { get; }
        public IPermissionRepo PermissionRepo { get; }

        public Task Dispose();

        public Task<bool> SaveChanges();
    }
}
