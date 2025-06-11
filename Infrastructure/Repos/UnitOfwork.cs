using Domain.Interfaces.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly AppDbContext context;

        private IEmployeeRepo employeeRepo;
        private ICashBoxesRepo cashBoxesRepo;
        private IPermissionRepo permissionRepo;

        public UnitOfwork(AppDbContext context)
        {
            this.context = context;
        }

        public IEmployeeRepo EmployeeRepo => employeeRepo ?? new EmployeeRepo(context);

        public ICashBoxesRepo CashBoxesRepo => cashBoxesRepo ?? new CashBoxRepo(context);

        public IPermissionRepo PermissionRepo => permissionRepo ?? new PermssionRepo(context);

        public async Task Dispose()
        {
            await context.DisposeAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return (await context.SaveChangesAsync()) > 0;
        }
    }
}
