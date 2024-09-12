using NeuroDrive.Domain.Enums;
using NeuroDrive.Domain.Models;
using NeuroDrive.UI.ViewModels;

namespace NeuroDrive.UI.Mappers;

public static class MapMapper
{
    public static IEnumerable<MapCellViewModel> ToViewModels(Map map)
    {
        return map.Cells
            .OrderBy(c => c.Row)
            .ThenBy(c => c.Column)
            .Select(cell => new MapCellViewModel
            {
                CssClass = cell.CellType == CellType.Road ? "road" : "off-road"
            });
    }
}
