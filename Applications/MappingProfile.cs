using Applications.Services;
using AutoMapper;
using Domain.DTOs.CashBoxes;
using Domain.DTOs.Employees;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewCashBoxDto, CashBox>();

            CreateMap<NewEmployee, Employee>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => DataStatus.Active))
                .ForMember(dest => dest.CashBox, opt => opt.MapFrom(src => src.CashBox));

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission.Name))
                .ForMember(dest => dest.CashBoxName, opt => opt.MapFrom(src => src.CashBox != null ? src.CashBox.Name : string.Empty));
        }
    }
}
