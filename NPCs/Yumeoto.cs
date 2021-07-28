using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;
using ChanoMod.Items;

namespace ChanoMod.NPCs
{
    [AutoloadHead]
    class Yumeoto : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yumeoto");
            DisplayName.AddTranslation(GameCulture.Chinese, "梦音");
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 27;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return numTownNPCs >= 0 && money >= 0;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            int score = 0;
            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {
                    int type = Main.tile[x, y].type;
                    if (type == TileID.PartyMonolith) score++;
                }
            }
            return base.CheckConditions(left, right, top, bottom) && score >= 1;
        }
        public override string TownNPCName()
        {
            return Language.GetTextValue("Mods.ChanoMod.NPCName.Chano");
        }
        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();
            chat.Add(Language.GetTextValue("Mods.ChanoMod.Talk.great"));
            chat.Add(Language.GetTextValue("Mods.ChanoMod.Talk.hello_everyone_im_yumeoto_chano"));
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active) continue;

                foreach (Item item in player.inventory)
                {
                    if (item.type == ModContent.ItemType<YumeotoCandy>())
                    {
                        chat.Add(string.Format(Language.GetTextValue("Mods.ChanoMod.Talk.0_welcome_becoming_a_yumeoto_candy"), player.name));
                    }
                }
            }
            return chat.Get();
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");   // Shop
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            shop = true;
        }
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<YumeotoCandy>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Marshmallow);
            nextSlot++;
        }
    }
}
