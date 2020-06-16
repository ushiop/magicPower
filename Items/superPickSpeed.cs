using Terraria.ID;
using Terraria.ModLoader;
using Terraria;  
using static Terraria.ModLoader.ModContent;  
 using Microsoft.Xna.Framework;

namespace magicPower.Items
{
	public class superPickSpeed : ModItem
	{

	 
		public override void UpdateInventory(Player player){
            player.pickSpeed-=(player.pickSpeed*0.5f);
			//Dust.NewDust( player.position, player.width, player.height,91, 0f, 0f, 0,new Color(255,255,255), 1f);	
        }

		/*public override bool UseItem(Player player){  
			
        } */
		public override void SetStaticDefaults() 
		{  
            DisplayName.SetDefault("超级挖掘机护符"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("挖掘/采集速度+50%");
			
		}

		public override void SetDefaults() 
		{
			 
            item.noMelee = true; 
            item.width = 40;
			item.height = 40;   
            item.value = 1000;
            item.rare = -1;   
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}