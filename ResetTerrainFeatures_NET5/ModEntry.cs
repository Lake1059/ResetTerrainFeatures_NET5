using System;
using ResetTerrainFeatures.Menu;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace ResetTerrainFeatures 
{
	// Token: 0x02000004 RID: 4
	public class ModEntry : Mod
	{

		// Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public override void Entry(IModHelper helper)
		{
			Logger.monitor = base.Monitor;
			this.Config = helper.ReadConfig<ModConfig>();
			helper.Events.Input.ButtonPressed += this.ButtonPressed;


		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F8 File Offset: 0x000003F8
		public void ButtonPressed(object sender, ButtonPressedEventArgs e) 
		{
			bool flag = (Game1.currentLocation != null || this.debug) && !Game1.menuUp && Game1.activeClickableMenu == null && e.Button == this.Config.MenuKey;
			if (flag)
			{
		 		OBJ_i18n.RESETALLLOCATIONS = Helper.Translation.Get("RESETALLLOCATIONS");
				OBJ_i18n.SelectObjectChanged = Helper.Translation.Get("SelectObjectChanged");
				OBJ_i18n.Bush = Helper.Translation.Get("Bush");
				OBJ_i18n.Tree = Helper.Translation.Get("Tree");
				OBJ_i18n.Weed = Helper.Translation.Get("Weed");
				OBJ_i18n.Grass = Helper.Translation.Get("Grass");
				OBJ_i18n.Twig = Helper.Translation.Get("Twig");
				OBJ_i18n.Rock = Helper.Translation.Get("Rock");
				OBJ_i18n.Forage = Helper.Translation.Get("Forage");
				OBJ_i18n.Stump = Helper.Translation.Get("Stump");
				OBJ_i18n.Log = Helper.Translation.Get("Log");
				OBJ_i18n.Boulder = Helper.Translation.Get("Boulder");
				OBJ_i18n.Path = Helper.Translation.Get("Path");
				OBJ_i18n.Fence = Helper.Translation.Get("Fence");
				OBJ_i18n.Crop = Helper.Translation.Get("Crop");
				OBJ_i18n.TilledSoil = Helper.Translation.Get("TilledSoil");
				OBJ_i18n.Objects = Helper.Translation.Get("Objects");
				OBJ_i18n.TFeature = Helper.Translation.Get("TFeature");
				OBJ_i18n.Reset = Helper.Translation.Get("Reset");
				OBJ_i18n.Clear = Helper.Translation.Get("Clear");
				OBJ_i18n.Generate = Helper.Translation.Get("Generate");
				Game1.activeClickableMenu = new ResetMenu(20, 20, 200, 200);

			}
		}

		// Token: 0x04000003 RID: 3
		public bool debug = false;

		// Token: 0x04000004 RID: 4
		private ModConfig Config;

	}

}
