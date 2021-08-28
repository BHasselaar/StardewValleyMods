using Microsoft.Xna.Framework;
using StardewValley;
using System.Collections.Generic;

namespace RetainingSoil
{
    public class ModData
    {
        public List<List<TileData>> data { get; set; }

        public ModData()
        {
            data = new List<List<TileData>>();
        }

        public void SaveData(Dictionary<GameLocation, List<TileData>> dictionary)
        {
            foreach (KeyValuePair<GameLocation, List<TileData>> entry in dictionary)
            {
                data.Add(entry.Value);
            }
        }

        public class TileData
        {
            public Vector2 tiles { get; set; }
            public string location { get; set; }
            public int waterStored { get; set; }
            public int fertilizer { get; set; }

            public TileData(Vector2 tiles, string location, int fertilizer, int waterStored = 0)
            {
                this.tiles = tiles;
                this.location = location;
                this.waterStored = waterStored;
                this.fertilizer = fertilizer;
            }
        }
    }
}
