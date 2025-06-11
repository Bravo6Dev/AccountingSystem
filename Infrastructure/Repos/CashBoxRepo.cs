using Domain.Entities;
using Domain.Interfaces.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class CashBoxRepo : BaseRepo<CashBox>, ICashBoxesRepo
    {

        public CashBoxRepo(AppDbContext context) : base(context)
        {
        }
    }
}
