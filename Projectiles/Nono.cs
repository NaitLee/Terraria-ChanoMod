using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChanoMod.Projectiles
{
    class Nono : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.PetLizard);
            projectile.width = 30;
            projectile.height = 30;
            aiType = ProjectileID.PetLizard;
        }
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.lizard = false;
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            if (player.FindBuffIndex(ModContent.BuffType<Buffs.Nono>()) != -1)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
