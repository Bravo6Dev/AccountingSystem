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
        private readonly IUnitOfWork unitOfWork;
        private IMapper _mapper;
        private IPasswordService passwordService;
 
        private Lazy<IEmployeeService> employeeService;

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {
            this.unitOfWork = unitOfWork;
            this._mapper = mapper;
            this.passwordService = passwordService;
            employeeService = new Lazy<IEmployeeService>(() => new EmployeeServices(unitOfWork, mapper, passwordService));
        }
        public IEmployeeService EmployeeService => employeeService.Value;
    }
}
