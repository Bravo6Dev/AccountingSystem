using AutoMapper;
using Domain.Interfaces.Repos;
using Domain.Interfaces.Services;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class ServiceManager : IServiceManager
    {

        private Lazy<IEmployeeService> employeeService;
        private Lazy<IPermissionService> permissionService;
        private Lazy<ICashBoxService> cashBoxService;

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {
            cashBoxService = new Lazy<ICashBoxService>(() => new CashBoxService(unitOfWork));
            employeeService = new Lazy<IEmployeeService>(() => new EmployeeServices(unitOfWork, mapper, passwordService));
            permissionService = new Lazy<IPermissionService>(() => new PermissionService(unitOfWork));
        }
        public IEmployeeService EmployeeService => employeeService.Value;

        public IPermissionService PermissionService => permissionService.Value;

        public ICashBoxService CashBoxService => cashBoxService.Value;
    }
}
