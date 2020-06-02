using TruePower.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TruePower.Items.Weapons
{
    public class DirtJavelin : ModItem
    {
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 10f;
            item.damage = 20;
            item.knockBack = 5f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.rare = ItemRarityID.Red;

            item.consumable = false;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = false;
            item.melee = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(silver: 1);
            item.shoot = ModContent.ProjectileType<DirtJavelinProjectile>();

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 100);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}