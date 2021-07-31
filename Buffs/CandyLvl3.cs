using Terraria;
using Terraria.ModLoader;

namespace ChanoMod.Buffs
{
    class CandyLvl3 : Candy
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 7;
            player.statDefense += 4;
        }
    }
}
