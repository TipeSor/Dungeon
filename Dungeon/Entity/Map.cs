using SharpEngine.Core.Entity;

public class Map : Entity
{
    public const int TileSize = 32;

    public MapRenderer Renderer { get; }

    public Map()
    {
        Renderer = AddComponent(new MapRenderer()
        {
            TileSize = 32,
        });
    }
}