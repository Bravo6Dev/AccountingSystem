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

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {

            employeeService = new Lazy<IEmployeeService>(() => new EmployeeServices(unitOfWork, mapper, passwordService));
            permissionService = new Lazy<IPermissionService>(() => new PermissionService(unitOfWork));
        }
        public IEmployeeService EmployeeService => employeeService.Value;

        public IPermissionService PermissionService => permissionService.Value;
    }
}
