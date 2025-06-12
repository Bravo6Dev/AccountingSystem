using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repos;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    internal class PermissionService : IPermissionService
    {
        private readonly IUnitOfWork unitOfWork;

        public PermissionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Result<IEnumerable<Permission>>> GetPermissions()
        {
            IEnumerable<Permission> data = await unitOfWork.PermissionRepo.GetAllAsync();
            return Result<IEnumerable<Permission>>.Success(data, Domain.Enums.ResultStatus.Success);
        }
    }
}
