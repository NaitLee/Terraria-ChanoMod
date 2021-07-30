using Terraria;
using Terraria.ModLoader;
using ChanoMod.Items;
using Terraria.Localization;

namespace ChanoMod
{
    public class ChanoMod : Mod
    {
        // Now this file mainly does BGM switch

        // Terraria have no kana font glyphs... Let's use romaji
        private readonly string[] songs = {
            "梦音Miku - sansettoma-chi",  // サンセットマーチ
            "梦音Miku, 花泽香菜 - sweets parade",
            "梦音Miku - haro-hawayu",     // ハロ／ハワユ
            "梦音Miku - Poker Face"
        };
        // The length of each song, in seconds
        private readonly int[] songsTime = { 
            228,
            242,
            288,
            235
        };
        private int nowPlaying = 0;
        private int ticksPassed = int.MaxValue;
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }
            Player player = Main.LocalPlayer;
            bool playerHaveMP3 = false;
            for (int i = 0; i < player.armor.Length; i++)
            {
                Item item = player.armor[i];
                if (item.type == ModContent.ItemType<MP3Player>())
                {
                    playerHaveMP3 = true;
                    break;
                }
            }
            if (playerHaveMP3)
            {
                if (ticksPassed > songsTime[nowPlaying] * 60)
                {
                    nowPlaying = Main.rand.Next(songs.Length);
                    ticksPassed = 0;
                    Main.NewText(string.Format("[c/fedff6:{0}]", string.Format(Language.GetTextValue("Mods.ChanoMod.Message.now_playing_0", songs[nowPlaying]))));
                }
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/" + songs[nowPlaying]);
                priority = MusicPriority.BiomeHigh;
                if (Main.hasFocus) ticksPassed++;
            }
            else
            {
                ticksPassed = 0;
            }
        }
    }
}
