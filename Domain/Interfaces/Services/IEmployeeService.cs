using Domain.DTOs;
using Domain.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Result> Login(LoginDto login, CancellationToken cancellationToken);
        Task<Result> AddNewEmployee(NewEmployee employee, CancellationToken cancellationToken);
        Task<Result<IEnumerable<EmployeeDto>>> GetEmployees();
        Task<Result<PaginationResponse<EmployeeDto>>> GetEmployees(int page, int pageSize = 10);
        Task<Result<EmployeeDto>> GetEmployeeById(int id, CancellationToken cancellationToken);
        Task<Result> DeleteEmplyoee(int id);
        Task<Result> UpdateEmplyee(int id, NewEmployee employee);
    }
}
