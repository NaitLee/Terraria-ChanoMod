using Terraria.ModLoader;
using Terraria.ID;

namespace ChanoMod.Items
{
    class YumeotoCharm : ModItem
    {
        public override void SetDefaults()
        {
            item.accessory = true;
            item.defense = 2;
            item.lifeRegen = 3;
            item.rare = ItemRarityID.Orange;
            item.value = 80000;
        }
    }
}
