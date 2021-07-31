using Terraria;
using Terraria.ModLoader;

namespace ChanoMod.Buffs
{
    class CandyLvl2 : Candy
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 5;
            player.statDefense += 2;
        }
    }
}
