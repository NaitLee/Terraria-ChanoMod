using Terraria.ID;
using Terraria.ModLoader;
using ChanoMod.Buffs;

namespace ChanoMod.Items
{
    class YumeotoCandy : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("So sweet~\nBoosts life regeneration.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item2;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.value = 800;
            item.buffType = ModContent.BuffType<Candy>();
            item.buffTime = 10800;
        }
    }
}
