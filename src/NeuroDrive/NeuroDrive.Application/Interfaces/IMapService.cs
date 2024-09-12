using NeuroDrive.Domain.Models;

namespace NeuroDrive.Application.Interfaces;

public interface IMapService
{
    Task<Map> GetMapAsync();

    Task UpdateMapAsync(Map map);
}
