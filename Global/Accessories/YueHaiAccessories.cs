using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YueHaiTheMoreRecipes.Global.Accessories
{
    public class YueHaiAccessories : GlobalItem
    {
        public override void UpdateAccessory(Terraria.Item item, Player player, bool hideVisual)
        {
            //天界星盘
            if (item.type == ItemID.LongRainbowTrailWings)
            {
                //使天界星盘可以无限飞
                player.wingTime = 180;
                //水平移动速度改为大概40mph
                player.moveSpeed = 2.6f;

                //防御力
                //item.defense = 999;
            }

            //泰拉闪耀靴
            if (item.type == ItemID.TerrasparkBoots)
            {
                //水平移动速度改为大概37mph
                player.moveSpeed = 2.4f;

            }
        }


        //提炼机，但是好像没用
        public override void ExtractinatorUse(int extractType, ref int resultType, ref int resultStack)
        {
            if (extractType == ItemID.DirtBlock)
            {
                //resultType = 20;
                //resultStack = 1;
            }
        }

    }
}
