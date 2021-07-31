using Terraria.ModLoader;
using Terraria.ID;
using ChanoMod.Buffs;

namespace ChanoMod.Items
{
    class YumeotoCandyLvl3 : YumeotoCandy
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.buffType = ModContent.BuffType<CandyLvl3>();
            item.buffTime = 43200;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<YumeotoCandyLvl2>(), 2);
            recipe.AddIngredient(ItemID.Daybloom);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
