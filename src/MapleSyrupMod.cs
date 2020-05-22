using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace VSExampleMods
{
    public class MapleSyrupMod : ModSystem
    {

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("trampoline", typeof(TrampolineBlock));
        }
    }
}