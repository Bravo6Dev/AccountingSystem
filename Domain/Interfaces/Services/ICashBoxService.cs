using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ICashBoxService 
    {
        Task<Result<PaginationResponse<CashBox>>> GetCashBoxesAsync(int page, int pageSize = 10);
        Task<Result> DeleteCashBoxAsync(int Id);
        Task<Result> AddNewCashBox(string name);
    }
}
