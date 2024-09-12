using NeuroDrive.Application.Interfaces;
using NeuroDrive.Domain.Enums;
using NeuroDrive.Domain.Models;

namespace NeuroDrive.Infrastructure.Repositories;

public sealed class MapRepository : IMapRepository
{
    public async Task<Map> GetMapAsync()
        => await Task.FromResult(InitializeMap());

    public async Task UpdateMapAsync(Map map)
        => throw new NotImplementedException();

    private static Map InitializeMap()
    {
        int rows = 10;
        int columns = 10;
        var cells = new List<MapCell>();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                int index = row * columns + col;
                var cellType = (index > 30 && index < 39) ? CellType.Road : CellType.OffRoad;

                cells.Add(new MapCell
                {
                    Row = row,
                    Column = col,
                    CellType = cellType
                });
            }
        }

        return new Map
        {
            Rows = rows,
            Columns = columns,
            Cells = cells
        };
    }
}
