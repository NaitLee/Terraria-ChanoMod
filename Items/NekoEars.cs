using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChanoMod.Items
{
    class NekoEars : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LizardEgg);
            item.shoot = ModContent.ProjectileType<Projectiles.Nono>();
            item.buffType = ModContent.BuffType<Buffs.Nono>();
            item.value = 50000;
            item.rare = ItemRarityID.Pink;
        }
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
