using Terraria.ID;
using Terraria.ModLoader;
using Terraria;  
using static Terraria.ModLoader.ModContent;  
 

namespace magicPower.Items
{
	public class normalTools : ModItem
	{

		public override void HoldItem(Player player){ 
            player.AddBuff(BuffType<Buffs.normalToolsBuff>(), 60);
            //Lighting.AddLight(p.position, 1f, 1f, 1f); 
        } 
 

		/*public override bool UseItem(Player player){  
			
        } */
		public override void SetStaticDefaults() 
		{  
            DisplayName.SetDefault("普通的采集工具"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("不受采集之苦，专注于战斗吧！");
			
		}

		public override void SetDefaults() 
		{
			
			item.damage = 1; 
            item.melee = true;
            item.axe = 200;
            item.pick = 1000;
            //item.hammer = 1000;
            item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = 1000;
            item.rare = -1; 
            item.UseSound = SoundID.Item1;
			item.autoReuse = true;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}