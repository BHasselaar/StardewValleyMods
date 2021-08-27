using StardewModdingAPI;

namespace RetainingSoil
{
    public class ModEntry : Mod
    {
        public ModConfig config;
        public override void Entry(IModHelper helper)
        {
            config = helper.ReadConfig<ModConfig>();

            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;
        }

        private void GameLoop_SaveLoaded(object sender, StardewModdingAPI.Events.SaveLoadedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
