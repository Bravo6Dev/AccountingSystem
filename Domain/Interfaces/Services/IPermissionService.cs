using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IPermissionService
    {
        Task<Result<IEnumerable<Permission>>> GetPermissions();
    }
}
