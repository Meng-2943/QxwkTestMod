using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

using QxwkTestMod.Projectiles;//使用弹幕库
using QxwkTestMod.Items.Weapons;//使用物品库
using Terraria.Audio;//使用音频

namespace QxwkTestMod.Items.Guns//命名空间
{
    public class ColorfulRegularGun : ModItem//物品类型
    {
        public override void SetStaticDefaults()//基本属性
        {
            DisplayName.SetDefault("五彩缤纷的普通枪");//名字
            Tooltip.SetDefault("攻速很快的枪");//介绍
            
            Item.maxStack = 1;//堆叠数
        }

        public override void SetDefaults()//特殊属性
        {
            Item.width = 80;//物品宽度
            Item.height = 80;//物品高度
            Item.value = Item.buyPrice(gold: 20);//售价

            Item.useStyle = ItemUseStyleID.Shoot;//怎么用
            Item.useTime = 6;//使用时间
            Item.useAnimation = 6;//另一个使用时间
            Item.autoReuse = true;//连续使用？
            Item.useTurn = false;//使用时可以转身？
            Item.UseSound = SoundID.Item1;//使用音效

            Item.DamageType = DamageClass.Ranged;//伤害类型
            Item.damage = 500;//伤害
            Item.scale = 0.75f;//伤害范围
            Item.knockBack = 5f;//击退
            Item.crit = 6;//暴击率
            Item.noMelee = true;//本体没有伤害

            Item.accessory = false;//饰品？
            Item.rare = 8;//稀有度

            Item.UseSound = new SoundStyle($"{nameof(QxwkTestMod)}/Assets/Sounds/ColorfulRegularGun") //使用声音
            {
				Volume = 0.9f,
				PitchVariance = 0.2f,
				MaxInstances = 3,
            };

            Item.shoot = ProjectileID.PurificationPowder;//子弹
			Item.shootSpeed = 10f;
			Item.useAmmo = AmmoID.Bullet;
        }

        public override Vector2? HoldoutOffset() //限制角度
        {
			return new Vector2(2f, -2f);
        }

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)//随机子弹
        {
			type = Main.rand.Next(new int[] 
            { 
                type, 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectileBlue>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectileGreen>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectileOrange>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectilePink>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectilePurple>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectileRed>(), 
                ModContent.ProjectileType<Projectiles.ColorfulRegularGunProjectileYellow>(), 
            });
		}

        /*
        public override void AddRecipes()//合成表
        {
            Recipe recipe = CreateRecipe();//开头
            recipe.AddIngredient(ItemID.AdamantiteBar, 2);//需要的物品
            recipe.AddIngredient(ItemID.CrimtaneBar, 2);
            recipe.AddIngredient(ItemID.PalladiumBar, 2);
            recipe.AddIngredient(ItemID.HellstoneBar, 2);
            recipe.AddIngredient<Test>(1);
            recipe.AddTile(TileID.WorkBenches);//需要的合成站
            recipe.Register();//结束
        }
        */
    }
}