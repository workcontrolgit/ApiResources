using ApiResources.Application.Features.Employees.Queries.GetEmployees;
using ApiResources.Application.Parameters;
using ApiResources.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResources.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}