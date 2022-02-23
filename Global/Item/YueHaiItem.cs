using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YueHaiTheMoreRecipes.Global.Item
{
    public class YueHaiItem : GlobalItem
    {
        public override void SetDefaults(Terraria.Item item)
        {
            //让物品最大堆叠为9999
            item.maxStack = 9999;

            //让物品不消耗
            //item.consumable = false;

            // 决定了这个武器鼠标按住不放能不能一直攻击
            item.autoReuse = true;
        }


    }
}
