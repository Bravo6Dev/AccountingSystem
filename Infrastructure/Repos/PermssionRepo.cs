using Domain.Entities;
using Domain.Interfaces.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class PermssionRepo : BaseRepo<Permission>, IPermissionRepo
    {
        public PermssionRepo(AppDbContext context) : base(context)
        {
            
        }
    }
}
