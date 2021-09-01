using ApiResources.Application.Features.Employees.Queries.GetEmployees;
using ApiResources.Application.Features.Positions.Commands.CreatePosition;
using ApiResources.Application.Features.Positions.Queries.GetPositions;
using ApiResources.Domain.Entities;
using AutoMapper;

namespace ApiResources.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}