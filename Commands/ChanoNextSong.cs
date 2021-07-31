using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;

namespace ChanoMod.Commands
{
    class ChanoNextSong : ModCommand
    {
        public override string Command => "chano-next-song";
        public override CommandType Type => CommandType.Chat;
        public override string Usage => "/chano-next-song";
        public override string Description => Language.GetTextValue("Mods.ChanoMod.Message.switch_to_next_song");
        public override void Action(CommandCaller caller, string input, string[] args)
        {
            ModContent.GetInstance<ChanoMod>().ticksPassed = int.MaxValue;
        }
    }
}
