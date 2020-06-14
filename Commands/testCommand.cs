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
using Newtonsoft.Json.Linq; 
 

namespace magicPower.Commands
{
	public class testCommand : ModCommand
	{
		private JObject  playerInfo=new JObject();

		public override CommandType Type
			=> CommandType.Chat;

		public override string Command
			=> "p";
 
 

		public override void Action(CommandCaller caller, string input, string[] args) {
			 
			var type = caller.Player.GetType();
			var Fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            string name;
			mod.Logger.Info("==========="); 
            foreach (var info in Fields)
				{
					//mod.Logger.Info(info.Name.ToString()+"/"+info.GetValue(caller.Player).ToString()); // at log-level INFO
					name=info.Name.ToString();
					if(name=="gemCount"||
						name=="miscCounter"||
						name=="infernoCounter"||
						name=="shadowCount"||
						name=="lifeRegenCount"||
						name=="manaRegenCount"||
						name=="lifeRegen"||
						name=="handon"||
						name=="shoe"||
						name=="pickSpeed"||
						name=="lifeRegen"||
						name=="lifeRegenTime"){
							continue;
						}
						
					if(playerInfo[name]==null){
						playerInfo[name]=info.GetValue(caller.Player).ToString();
					}else{
						if(info.GetValue(caller.Player).ToString()!=playerInfo[name].ToString()){
							Main.NewText("属性["+name+"]变化了,旧/新值["+playerInfo[name]+"/"+info.GetValue(caller.Player).ToString()+"]");
							playerInfo[name]=info.GetValue(caller.Player).ToString();
						}
					}
				}
            Main.NewText("player类的属性已输出完毕。"); 
		
        
		}
	}
}