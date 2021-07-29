using Terraria;
using Terraria.ModLoader;

namespace ChanoMod.Buffs
{
    class Tea : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;
            player.statDefense += 1;
            player.magicDamageMult += 0.08f;
        }
    }
}
