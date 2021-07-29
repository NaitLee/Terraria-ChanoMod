using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using ChanoMod.Buffs;

namespace ChanoMod.Items
{
    class YumeotoTea : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.value = 1500;
            item.buffType = ModContent.BuffType<Tea>();
            item.buffTime = 21600;
        }
    }
}
