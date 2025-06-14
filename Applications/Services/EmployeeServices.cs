using Applications.Util;
using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.Employees;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repos;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPasswordService passwordService;

        public EmployeeServices(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {
            this.unitOfWork = unitOfWork;
            this._mapper = mapper;
            this.passwordService = passwordService;

        }

        public async Task<Result> AddNewEmployee(NewEmployee employee, CancellationToken cancellationToken)
        {
            if (await unitOfWork.EmployeeRepo.IsExistAsync(e => e.PhoneNumber == employee.PhoneNumber.Trim()))
                return Result.Failure(Messages.ExistEmployee, ResultStatus.Failed);

            Employee newEmployee = _mapper.Map<Employee>(employee); 
            newEmployee.Passowrd = passwordService.HashPassword(newEmployee.Passowrd);

            await unitOfWork.EmployeeRepo.AddAsync(newEmployee);

            if (!await unitOfWork.SaveChanges())
                return Result.Failure(Messages.SqlError, ResultStatus.Failed);
            return Result.Success(ResultStatus.Success);
        }

        public async Task<Result<EmployeeDto>> GetEmployeeById(int id, CancellationToken cancellationToken)
        {
            EmployeeDto? employee = await unitOfWork.EmployeeRepo.GetFirstOrDefaultAsync<EmployeeDto>(_mapper.ConfigurationProvider,
                    e => e.Id == id, asNoTracking:true, cancellationToken);
            if (employee == null)
                return Result<EmployeeDto>.Failure(string.Format(Messages.NotFound, "الموظف"), ResultStatus.Success);
            return Result<EmployeeDto>.Success(employee, ResultStatus.Success);
        }

        public async Task<Result<IEnumerable<EmployeeDto>>> GetEmployees()
        {
            IEnumerable<EmployeeDto> employees = await unitOfWork.EmployeeRepo.GetAllAsync<EmployeeDto>(_mapper.ConfigurationProvider);
            return Result<IEnumerable<EmployeeDto>>.Success(employees, ResultStatus.Success);
        }

        public async Task<Result<PaginationResponse<EmployeeDto>>> GetEmployees(int page, int pageSize = 10)
        {
            PaginationResponse<EmployeeDto> data = await unitOfWork.EmployeeRepo.GetAllAsync<EmployeeDto>(page, pageSize,
                   _mapper.ConfigurationProvider);
            return Result<PaginationResponse<EmployeeDto>>.Success(data, ResultStatus.Success);
        }

        public async Task<Result> Login(LoginDto login, CancellationToken cancellationToken)
        {
            string? Password = await unitOfWork.EmployeeRepo.GetFirstOrDefaultAsync<string>(e => e.Passowrd,
                e => e.Username == login.Username.Trim());

            if (string.IsNullOrEmpty(Password))
                return Result.Failure(string.Format(Messages.NotFound, "الموظف"), ResultStatus.Failed);
            if (!passwordService.VerifyPassword(login.Password, Password))
                return Result.Failure(Messages.WrongCredentials, ResultStatus.Failed);

            return Result.Success(ResultStatus.Success);
        }
    }
}
