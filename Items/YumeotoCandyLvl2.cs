using Terraria.ModLoader;
using Terraria.ID;
using ChanoMod.Buffs;

namespace ChanoMod.Items
{
    class YumeotoCandyLvl2 : YumeotoCandy
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.buffType = ModContent.BuffType<CandyLvl2>();
            item.buffTime = 21600;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<YumeotoCandy>(), 2);
            recipe.AddIngredient(ItemID.Mushroom);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}
