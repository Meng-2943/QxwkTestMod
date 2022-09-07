using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using System;
using QxwkTestMod.Projectiles;
using QxwkTestMod.Items.Weapons;

namespace QxwkTestMod.Items.Weapons
{
    public class ChaosTwinSwordsRed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("混沌双刃 红");
            Tooltip.SetDefault("红色的");
            Item.value = 4500000;
            Item.width = 120;
            Item.height = 120;
            Item.maxStack = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 50000;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.scale = 2.5f;
            Item.knockBack = 0f;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.accessory = false;
            Item.UseSound = SoundID.Item1;
            Item.crit = 15;
            Item.rare = 11;

            Item.shoot = ModContent.ProjectileType<ChaosTwinSwordsRedProjectiles>();
            Item.shootSpeed = 15f;
        }

        public override void AddRecipes()//合成表
        {
            Recipe recipe = CreateRecipe();//开头
            recipe.AddIngredient<RedEmptySwords>(3);//需要的物品
            recipe.AddTile(TileID.WorkBenches);//需要的合成站
            recipe.Register();//结束
        }
    }
}