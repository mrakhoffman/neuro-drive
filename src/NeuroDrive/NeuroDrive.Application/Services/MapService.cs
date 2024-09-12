using NeuroDrive.Application.Interfaces;
using NeuroDrive.Domain.Models;

namespace NeuroDrive.Application.Services;

public sealed class MapService(IMapRepository mapRepository) : IMapService
{
    public async Task<Map> GetMapAsync()
        => await mapRepository.GetMapAsync();

    public async Task UpdateMapAsync(Map map)
        => await mapRepository.UpdateMapAsync(map);
}
