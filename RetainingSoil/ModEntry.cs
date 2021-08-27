using Microsoft.Xna.Framework;
using RetainingSoil.framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.TerrainFeatures;
using System.Collections.Generic;

namespace RetainingSoil
{
    public class ModEntry : Mod
    {
        public ModConfig modConfig;
        public ModData modData;

        public override void Entry(IModHelper helper)
        {
            modConfig = this.Helper.ReadConfig<ModConfig>();
            modData = this.Helper.Data.ReadSaveData<ModData>("RetainingSoil") ?? new ModData();

            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;
            helper.Events.GameLoop.DayStarted += GameLoop_DayStarted;
            helper.Events.GameLoop.DayEnding += GameLoop_DayEnding;
        }

        private void GameLoop_DayEnding(object sender, DayEndingEventArgs e)
        {
            if (Game1.IsMasterGame)
            {
                Dictionary<GameLocation, List<TileData>> data = new Dictionary<GameLocation, List<TileData>>();
                foreach (GameLocation location in getAllLocationsAndBuildings())
                {
                    if (location != null)
                    {
                        if (!data.ContainsKey(location))
                        {
                            data.Add(location, new List<TileData>());
                        }
                        List<TileData> list = new List<TileData>();
                        foreach (Dictionary<Vector2, TerrainFeature> dictionary in location.terrainFeatures)
                        {
                            foreach (KeyValuePair<Vector2, TerrainFeature> entry in dictionary)
                            {
                                if (entry.Value is HoeDirt)
                                {
                                    if ((((HoeDirt)entry.Value).fertilizer == 370 ||
                                         ((HoeDirt)entry.Value).fertilizer == 371 ||
                                         ((HoeDirt)entry.Value).fertilizer == 920) &&
                                         ((HoeDirt)entry.Value).state == 1)
                                    {
                                        foreach (Dictionary<Vector2, TileData> tileData in data[location])
                                        {
                                            
                                        }
                                    }
                                }
                            }
                        }
                        data[location] = list;
                    }
                }
                modData.LoadData(data);
                this.Helper.Data.WriteSaveData("RetainingSoil", modData);
            }
        }

        private void GameLoop_DayStarted(object sender, DayStartedEventArgs e)
        {
            if (Game1.IsMasterGame)
            {
                if (Game1.dayOfMonth == 1)
                {
                    //clear data
                }
            }
        }

        private void GameLoop_SaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            if (Game1.IsMasterGame)
            {
                modData = this.Helper.Data.ReadSaveData<ModData>("key") ?? new ModData();
                restoreHoeDirt();
            }
        }

        private void saveFertilizedDirt()
        {

        }

        private void restoreHoeDirt()
        {

        }

        private List<GameLocation> getAllLocationsAndBuildings()
        {
            List<GameLocation> locations = new List<GameLocation>();
            locations.Add(Game1.getFarm());
            //locations.Add(Game1.getLocationFromName("Greenhouse")); Later thing
            return locations;
        }
    }
}
