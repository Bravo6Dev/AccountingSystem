using Applications.Util;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repos;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class CashBoxService : ICashBoxService
    {
        private readonly IUnitOfWork unitOfWork;

        public CashBoxService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Result> AddNewCashBox(string name)
        {
            if (await unitOfWork.CashBoxesRepo.IsExistAsync(c => c.Name == name.Trim()))
                return Result.Failure(string.Format(Messages.ConflictMessage, "خزينة", "الاسم"), Domain.Enums.ResultStatus.Failed);

            await unitOfWork.CashBoxesRepo.AddAsync(new CashBox
            {
                Balance = 0,
                CreateDate = DateTime.Now,
                Name = name,
                Status = Domain.Enums.DataStatus.Active
            });

            if (!await unitOfWork.SaveChanges())
                return Result.Failure(Messages.SqlError, Domain.Enums.ResultStatus.Failed);
            return Result.Success(Domain.Enums.ResultStatus.Success);
        }

        public async Task<Result> DeleteCashBoxAsync(int Id)
        {
            int effectRows = await unitOfWork.CashBoxesRepo.BulkDeleteAsync(c => c.Id == Id);
            if (effectRows <= 0)
                return Result.Failure(Messages.SqlError, Domain.Enums.ResultStatus.Failed);
            return Result.Success(Domain.Enums.ResultStatus.Success);
        }

        public async Task<Result<PaginationResponse<CashBox>>> GetCashBoxesAsync(int page, int pageSize = 10)
        {
            PaginationResponse<CashBox> data = await unitOfWork.CashBoxesRepo.GetAllAsync(page, pageSize, asNoTracking:true);
            return Result<PaginationResponse<CashBox>>.Success(data, Domain.Enums.ResultStatus.Success);
        }
    
    }
}
