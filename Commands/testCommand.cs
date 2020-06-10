using Terraria.ID;
using Terraria.ModLoader;
using Terraria;  
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Terraria.Localization;

using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace magicPower.Commands
{
	public class testCommand : ModCommand
	{
		public override CommandType Type
			=> CommandType.Chat;

		public override string Command
			=> "pp";
 
 

		public override void Action(CommandCaller caller, string input, string[] args) {
			 
			var type = caller.Player.GetType();
			var Fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            mod.Logger.Info("===========");
            foreach (var info in Fields)
				{
					mod.Logger.Info(info.Name.ToString()+"/"+info.GetValue(caller.Player).ToString()); // at log-level INFO
				}
            Main.NewText("player类的属性已输出完毕。"); 
		
        
		}
	}
}