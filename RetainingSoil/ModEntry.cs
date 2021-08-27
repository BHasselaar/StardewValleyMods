using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace RetainingSoil
{
    public class ModEntry : Mod
    {
        public ModConfig config;
        public override void Entry(IModHelper helper)
        {
            config = helper.ReadConfig<ModConfig>();

            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;
            helper.Events.GameLoop.DayStarted += GameLoop_DayStarted;
            helper.Events.GameLoop.DayEnding += GameLoop_DayEnding;
        }

        private void GameLoop_DayEnding(object sender, DayEndingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void GameLoop_DayStarted(object sender, DayStartedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void GameLoop_SaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
