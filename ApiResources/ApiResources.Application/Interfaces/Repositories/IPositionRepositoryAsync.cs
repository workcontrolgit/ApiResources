using ApiResources.Application.Features.Positions.Queries.GetPositions;
using ApiResources.Application.Parameters;
using ApiResources.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResources.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}