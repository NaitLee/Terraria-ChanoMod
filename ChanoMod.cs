using ChanoMod.Items;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ChanoMod
{
    public class ChanoMod : Mod
    {
        // Now this file mainly does BGM switch

        static int GetSongTime(int minutes, int seconds) => minutes * 60 + seconds;

        // Terraria have no kana font glyphs... Let's use romaji
        public readonly string[] songs = {
            "梦音Miku - sansettoma-chi",  // サンセットマーチ
            "梦音Miku, 花泽香菜 - sweets parade",
            "梦音Miku - haro-hawayu",     // ハロ／ハワユ
            "梦音Miku - Poker Face",
            "梦音Miku - 芒种-日文版",
            "梦音茶糯 - RingRingRing",
            "梦音茶糯 - 稻香",
            "梦音茶糯 - 错位时空",
            "梦音茶糯 - 霞光"
        };
        // The length of each song, in seconds
        public readonly int[] songsTime = {
            GetSongTime(3, 48),
            GetSongTime(4, 0),
            GetSongTime(4, 48),
            GetSongTime(3, 55),
            GetSongTime(3, 34),
            GetSongTime(3, 25),
            GetSongTime(3, 34),
            GetSongTime(3, 28),
            GetSongTime(2, 36)
        };
        public int nowPlaying = 0;
        public int ticksPassed = int.MaxValue;
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
