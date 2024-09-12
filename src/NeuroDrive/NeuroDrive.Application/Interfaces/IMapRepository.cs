using NeuroDrive.Domain.Models;

namespace NeuroDrive.Application.Interfaces;

public interface IMapRepository
{
    Task<Map> GetMapAsync();

    Task UpdateMapAsync(Map map);
}
