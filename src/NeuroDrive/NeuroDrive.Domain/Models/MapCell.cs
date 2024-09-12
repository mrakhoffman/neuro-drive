using NeuroDrive.Domain.Enums;

namespace NeuroDrive.Domain.Models;

public sealed class MapCell
{
    public required int Row { get; set; }

    public required int Column { get; set; }

    public required CellType CellType { get; set; }
}
