using Microsoft.Xna.Framework;
using RetainingSoil.framework;
using StardewValley;
using System.Collections.Generic;

namespace RetainingSoil
{
    public class ModData
    {
        public List<Dictionary<Vector2, TileData>> data { get; set; }

        public ModData()
        {
            data = new List<Dictionary<Vector2, TileData>>();
        }
        public void SaveData(Dictionary<GameLocation, List<Vector2>> dictionary)
        {
            this.data = new List<TileData>();
            foreach (KeyValuePair<GameLocation, List<Vector2>> entry in dictionary)
            {
                this.data.Add(new TileData(entry.Key.name, entry.Value));
            }
        }
    }
}
