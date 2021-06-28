using System;
using System.Linq;
using TreehouseDefense;

public class Path
{
    private MapLocation[] _path;

    public int Length { get; internal set; }

    public Path(MapLocation[] pathLocations)
    {
        this._path = pathLocations;
    }

    public bool IsOnPath(MapLocation mapLocation) => _path.Contains(mapLocation);

    internal MapLocation GetLocationAt(int pathStep)
    {
        throw new NotImplementedException();
    }
}