namespace NeuroDrive.Domain.Models;

public sealed class Map
{
    public required int Rows { get; set; }

    public required int Columns { get; set; }

    public required List<MapCell> Cells { get; set; }
}
