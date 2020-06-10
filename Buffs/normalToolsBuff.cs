using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Terraria.Localization;

namespace magicPower.Buffs
{
	public class normalToolsBuff: ModBuff 
	{ 
		private static int cd=0;
		public override void SetDefaults() 
		{
            DisplayName.SetDefault("挖矿灯");
            Description.SetDefault("照亮鼠标周围");
			canBeCleared = true; 
			Main.buffNoTimeDisplay[Type] = false;
			Main.vanityPet[Type] = false;
			Main.lightPet[Type] = false;
        }

		public override void Update(Player player, ref int buffIndex) {
            //Main.NewText("??"); 
		
            //Lighting.AddLight(player.position, 1.5f, 1.5f, 1.5f); 
			if(cd==0){
				Dust.NewDust( Main.MouseWorld, player.width, player.height,91, 0f, 0f, 0,new Color(255,255,255), 1f);
				cd=5;
			}
			cd--;
		}
 
	} 
}