using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QxwkTestMod.Items.Weapons
{
	public class Test : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("合成的基础");
		}

		public override void SetDefaults()
		{
			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 7500;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}