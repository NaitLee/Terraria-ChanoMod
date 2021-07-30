using Terraria.ModLoader;
using Terraria.ID;

namespace ChanoMod.Items
{
    class MP3Player : ModItem
    {
        public override void SetDefaults()
        {
            item.accessory = true;
            item.vanity = true;
            item.rare = ItemRarityID.Pink;
            item.value = 100000;
        }
    }
}
