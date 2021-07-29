using Terraria;
using Terraria.ModLoader;

namespace ChanoMod.Buffs
{
    class Candy : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 3;
            player.statDefense += 1;
        }
    }
}
