using Microsoft.Xna.Framework;

namespace RetainingSoil.framework
{
    public class TileData
    {
        public Vector2 tiles { get; set; }
        public string location { get; set; }
        public int waterStored { get; set; }
        public int fertilizer { get; set; }

        public TileData(Vector2 tiles, string location, int waterStored, int fertilizer)
        {
            this.tiles = tiles;
            this.location = location;
            this.waterStored = waterStored;
            this.fertilizer = fertilizer;
        }
    }
}
