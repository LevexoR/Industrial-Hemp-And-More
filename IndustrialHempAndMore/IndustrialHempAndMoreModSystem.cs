using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace IndustrialHempAndMore
{
    public class IndustrialHempAndMoreModSystem : ModSystem
    {
        // Called on both server and client - use for shared registrations
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            Mod.Logger.Notification("Industrial Hemp and More initialized - Side: " + api.Side);
        }

        // Server-only logic (worldgen, crop growth, status effect application)
        public override void StartServerSide(ICoreServerAPI api)
        {
            base.StartServerSide(api);
            Mod.Logger.Notification("Industrial Hemp and More - Server side ready");

            // TODO: Register server-side systems here (e.g., PlayerTrySleep hook)
        }

        // Client-only logic (visual effects, UI overlays, shaders)
        public override void StartClientSide(ICoreClientAPI api)
        {
            base.StartClientSide(api);
            Mod.Logger.Notification("Industrial Hemp and More - Client side ready");

            // TODO: Register client-side event listeners here (e.g., vision effects)
        }
    }
}