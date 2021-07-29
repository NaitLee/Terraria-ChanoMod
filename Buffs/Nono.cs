using Terraria;
using Terraria.ModLoader;

namespace ChanoMod.Buffs
{
    class Nono : ModBuff
    {
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
			Main.debuff[Type] = false;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Nono>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Nono>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
            player.lifeRegen += 2;
		}
	}
}
