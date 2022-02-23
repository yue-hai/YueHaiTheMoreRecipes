using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YueHaiTheMoreRecipes.Global.NPCs
{
    class YueHaiNPCs : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            //史莱姆之王                 NPC.downedSlimeKing
            //克苏鲁之眼                 NPC.downedBoss1

            //血月：小丑                 NPC.downedClown
            //哥布林入侵                 NPC.downedGoblins;

            //世界吞噬怪&克苏鲁之脑      NPC.downedBoss2
            //骷髅王                     NPC.downedBoss3
            //蜂王                       NPC.downedQueenBee
            //击败肉山进入困难模式       Main.hardMode

            //史莱姆皇后                 NPC.downedQueenSlime
            //任何机械BOSS               NPC.downedMechBossAny;
            //机械双子魔眼               NPC.downedMechBoss1
            //机械魔眼毁灭者             NPC.downedMechBoss2
            //机械骷髅王                 NPC.downedMechBoss3

            //火星人入侵                 NPC.downedMartians
            //海盗入侵                   NPC.downedPirates

            //世纪之花                   NPC.downedPlantBoss
            //神庙石巨人                 NPC.downedGolemBoss

            //万圣节的树                 NPC.downedHalloweenTree
            //霜月                       NPC.downedFrost;
            //霜月：冰雪女王             NPC.downedChristmasIceQueen
            //霜月：圣诞坦克             NPC.downedChristmasSantank
            //霜月：常绿尖叫怪           NPC.downedChristmasTree
            
            //光之女皇                   NPC.downedEmpressOfLight
            //猪鲨                       NPC.downedFishron
            //远古教徒                   NPC.downedAncientCultist
            //星云                       NPC.downedTowerNebula
            //日耀                       NPC.downedTowerSolar
            //星尘                       NPC.downedTowerStardust
            //星旋                       NPC.downedTowerVortex
            //月亮领主                   NPC.downedMoonlord
            //*******************************************************

            //商人，鱼饵，一些药水、生命水晶、生命果
            if (type == NPCID.Merchant)
            {
                //学徒诱饵
                shop.item[nextSlot].SetDefaults(ItemID.ApprenticeBait);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
                
                //熟手诱饵
                shop.item[nextSlot].SetDefaults(ItemID.JourneymanBait);
                //设置价格
                shop.item[nextSlot].value = 1500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
                
                //大师诱饵
                shop.item[nextSlot].SetDefaults(ItemID.MasterBait);
                //设置价格
                shop.item[nextSlot].value = 5000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //*******************************************************

                //打败：克苏鲁之眼
                if (NPC.downedBoss1)
                {
                    //生命水晶
                    shop.item[nextSlot].SetDefaults(ItemID.LifeCrystal);
                    //设置价格
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //生命果
                    shop.item[nextSlot].SetDefaults(ItemID.LifeFruit);
                    //设置价格
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //*******************************************************

                //治疗药水
                shop.item[nextSlot].SetDefaults(ItemID.HealingPotion);
                //设置价格
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //超级治疗药水
                shop.item[nextSlot].SetDefaults(ItemID.SuperHealingPotion);
                //设置价格
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //恢复药水
                shop.item[nextSlot].SetDefaults(ItemID.RestorationPotion);
                //设置价格
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //再生药水
                shop.item[nextSlot].SetDefaults(ItemID.RegenerationPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //魔力再生药水
                shop.item[nextSlot].SetDefaults(ItemID.ManaRegenerationPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //铁皮药水
                shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //敏捷药水
                shop.item[nextSlot].SetDefaults(ItemID.SwiftnessPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //虫洞药水
                shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //返回药水
                shop.item[nextSlot].SetDefaults(ItemID.PotionOfReturn);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //重力药水
                shop.item[nextSlot].SetDefaults(ItemID.GravitationPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //危险感药水
                shop.item[nextSlot].SetDefaults(ItemID.TrapsightPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //狩猎药水
                shop.item[nextSlot].SetDefaults(ItemID.HunterPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //洞穴探险药水
                shop.item[nextSlot].SetDefaults(ItemID.SpelunkerPotion);
                //设置价格
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
            }

            //*******************************************************

            //染料商，木材、物块
            if (type == NPCID.DyeTrader)
            {
                //木材
                shop.item[nextSlot].SetDefaults(ItemID.Wood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //乌木
                shop.item[nextSlot].SetDefaults(ItemID.Ebonwood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //红木
                shop.item[nextSlot].SetDefaults(ItemID.RichMahogany);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //暗影木
                shop.item[nextSlot].SetDefaults(ItemID.Shadewood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //珍珠木
                shop.item[nextSlot].SetDefaults(ItemID.Pearlwood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //针叶木
                shop.item[nextSlot].SetDefaults(ItemID.BorealWood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //棕榈木
                shop.item[nextSlot].SetDefaults(ItemID.PalmWood);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：万圣节的树
                if (NPC.downedHalloweenTree)
                {
                    //阴森木
                    shop.item[nextSlot].SetDefaults(ItemID.SpookyWood);
                    //设置价格
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }
                
                //*******************************************************

                //蛛网
                shop.item[nextSlot].SetDefaults(ItemID.Cobweb);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //竹子
                shop.item[nextSlot].SetDefaults(ItemID.BambooBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //仙人掌
                shop.item[nextSlot].SetDefaults(ItemID.Cactus);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //泥沙
                shop.item[nextSlot].SetDefaults(ItemID.SiltBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //雪泥
                shop.item[nextSlot].SetDefaults(ItemID.SlushBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //沙漠化石
                shop.item[nextSlot].SetDefaults(ItemID.DesertFossil);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //土块
                shop.item[nextSlot].SetDefaults(ItemID.DirtBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //泥块
                shop.item[nextSlot].SetDefaults(ItemID.MudBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //粘土块
                shop.item[nextSlot].SetDefaults(ItemID.ClayBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //石块
                shop.item[nextSlot].SetDefaults(ItemID.StoneBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //黑檀石块
                shop.item[nextSlot].SetDefaults(ItemID.EbonstoneBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //猩红石块
                shop.item[nextSlot].SetDefaults(ItemID.CrimstoneBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //珍珠石块
                    shop.item[nextSlot].SetDefaults(ItemID.PearlstoneBlock);
                    //设置价格
                    shop.item[nextSlot].value = 20;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //沙块
                shop.item[nextSlot].SetDefaults(ItemID.SandBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //硬化沙块
                shop.item[nextSlot].SetDefaults(ItemID.HardenedSand);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //沙岩块
                shop.item[nextSlot].SetDefaults(ItemID.Sandstone);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //雪块
                shop.item[nextSlot].SetDefaults(ItemID.SnowBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //冰雪块
                shop.item[nextSlot].SetDefaults(ItemID.IceBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：蜂王
                if (NPC.downedQueenBee)
                {
                    //蜂巢
                    shop.item[nextSlot].SetDefaults(ItemID.Hive);
                    //设置价格
                    shop.item[nextSlot].value = 20;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //蜂蜜块
                    shop.item[nextSlot].SetDefaults(ItemID.HoneyBlock);
                    //设置价格
                    shop.item[nextSlot].value = 20;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //松脆蜂蜜块
                    shop.item[nextSlot].SetDefaults(ItemID.CrispyHoneyBlock);
                    //设置价格
                    shop.item[nextSlot].value = 20;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }
                
                //云
                shop.item[nextSlot].SetDefaults(ItemID.Cloud);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //雨云
                shop.item[nextSlot].SetDefaults(ItemID.RainCloud);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //雪云
                shop.item[nextSlot].SetDefaults(ItemID.SnowCloudBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //日盘块
                shop.item[nextSlot].SetDefaults(ItemID.SunplateBlock);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
            }

            //*******************************************************

            //树精：再生法杖、草药
            if (type == NPCID.Dryad)
            {
                //设置商品，再生法杖
                shop.item[nextSlot].SetDefaults(ItemID.StaffofRegrowth);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //*******************************************************

                //蘑菇
                shop.item[nextSlot].SetDefaults(ItemID.Mushroom);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //魔菇
                shop.item[nextSlot].SetDefaults(ItemID.VileMushroom);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //发光蘑菇
                shop.item[nextSlot].SetDefaults(ItemID.GlowingMushroom);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //南瓜
                shop.item[nextSlot].SetDefaults(ItemID.Pumpkin);
                //设置价格
                shop.item[nextSlot].value = 20;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //*******************************************************

                //闪耀根
                shop.item[nextSlot].SetDefaults(ItemID.Blinkroot);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //太阳花
                shop.item[nextSlot].SetDefaults(ItemID.Daybloom);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //月光草
                shop.item[nextSlot].SetDefaults(ItemID.Moonglow);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //寒颤棘
                shop.item[nextSlot].SetDefaults(ItemID.Shiverthorn);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //幌菊
                shop.item[nextSlot].SetDefaults(ItemID.Waterleaf);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //火焰花
                shop.item[nextSlot].SetDefaults(ItemID.Fireblossom);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //死亡草
                shop.item[nextSlot].SetDefaults(ItemID.Deathweed);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
            }

            //*******************************************************

            //哥布林，BOSS召唤，事件召唤，钥匙
            if (type == NPCID.GoblinTinkerer)
            {
                //打败：史莱姆之王
                if (NPC.downedSlimeKing)
                {
                    //设置商品，史莱姆王冠
                    shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
                    //设置价格：5金
                    shop.item[nextSlot].value = 40000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：克苏鲁之眼
                if (NPC.downedBoss1)
                {
                    //设置商品，可疑眼球
                    shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
                    //设置价格，5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世界吞噬怪 & 克苏鲁之脑
                if (NPC.downedBoss2)
                {
                    //设置商品，蠕虫诱饵
                    shop.item[nextSlot].SetDefaults(ItemID.WormFood);
                    //设置价格：5金
                    shop.item[nextSlot].value = 60000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，血腥脊椎
                    shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
                    //设置价格：5金
                    shop.item[nextSlot].value = 70000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：蜂王
                if (NPC.downedQueenBee)
                {
                    //设置商品，憎恶之蜂
                    shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
                    //设置价格：5金
                    shop.item[nextSlot].value = 80000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //设置商品，向导巫毒娃娃
                    shop.item[nextSlot].SetDefaults(ItemID.GuideVoodooDoll);
                    //设置价格：5金
                    shop.item[nextSlot].value = 90000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //*******************************************************

                //打败：机械双子魔眼
                if (NPC.downedMechBoss1)
                {
                    //设置商品，机械魔眼
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
                    //设置价格：5金
                    shop.item[nextSlot].value = 100000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：机械毁灭者
                if (NPC.downedMechBoss2)
                {
                    //设置商品，机械蠕虫
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
                    //设置价格：5金
                    shop.item[nextSlot].value = 110000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：机械骷髅王
                if (NPC.downedMechBoss3)
                {
                    //设置商品，机械骷髅头
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
                    //设置价格：5金
                    shop.item[nextSlot].value = 120000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：猪鲨
                if (NPC.downedFishron)
                {
                    //设置商品，松露虫
                    shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
                    //设置价格：5金
                    shop.item[nextSlot].value = 130000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：光之女皇
                if (NPC.downedEmpressOfLight)
                {
                    //设置商品，七彩草蛉
                    shop.item[nextSlot].SetDefaults(ItemID.EmpressButterfly);
                    //设置价格：5金
                    shop.item[nextSlot].value = 140000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：神庙石巨人
                if (NPC.downedGolemBoss)
                {
                    //设置商品，丛林蜥蜴电池
                    shop.item[nextSlot].SetDefaults(ItemID.LihzahrdPowerCell);
                    //设置价格：5金
                    shop.item[nextSlot].value = 150000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：月亮领主
                if (NPC.downedMoonlord)
                {
                    //设置商品，天界符
                    shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
                    //设置价格：5金
                    shop.item[nextSlot].value = 160000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }



                //*******************************************************

                //打败：血月：小丑
                if (NPC.downedClown)
                {
                    //设置商品，血泪
                    shop.item[nextSlot].SetDefaults(ItemID.BloodMoonStarter);
                    //设置价格：5金
                    shop.item[nextSlot].value = 20000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：哥布林入侵
                if (NPC.downedGoblins)
                {
                    //设置商品，哥布林战旗
                    shop.item[nextSlot].SetDefaults(ItemID.GoblinBattleStandard);
                    //设置价格
                    shop.item[nextSlot].value = 40000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //设置商品，水晶雪球
                    shop.item[nextSlot].SetDefaults(ItemID.SnowGlobe);
                    //设置价格
                    shop.item[nextSlot].value = 60000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：海盗入侵
                if (NPC.downedPirates)
                {
                    //设置商品，海盗地图
                    shop.item[nextSlot].SetDefaults(ItemID.PirateMap);
                    //设置价格
                    shop.item[nextSlot].value = 8000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //设置商品，南瓜月勋章
                    shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
                    //设置价格
                    shop.item[nextSlot].value = 10000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，调皮礼物
                    shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
                    //设置价格：5金
                    shop.item[nextSlot].value = 10000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，日耀碑牌
                    shop.item[nextSlot].SetDefaults(ItemID.SolarTablet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 10000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //*******************************************************

                //设置商品，金钥匙
                shop.item[nextSlot].SetDefaults(ItemID.GoldenKey);
                //设置价格：5金
                shop.item[nextSlot].value = 30000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，暗影钥匙
                shop.item[nextSlot].SetDefaults(ItemID.ShadowKey);
                //设置价格：5金
                shop.item[nextSlot].value = 50000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //设置商品，丛林钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.JungleKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，冰冻钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.FrozenKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，腐化钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.CorruptionKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，猩红钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.CrimsonKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，神圣钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.HallowedKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，沙漠钥匙
                    shop.item[nextSlot].SetDefaults(ItemID.DungeonDesertKey);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }
            }

            //*******************************************************

            //	爆破专家，矿石、宝石
            if (type == NPCID.Demolitionist)
            {
                //设置商品，铜矿
                shop.item[nextSlot].SetDefaults(ItemID.CopperBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，锡矿
                shop.item[nextSlot].SetDefaults(ItemID.TinBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，铁矿
                shop.item[nextSlot].SetDefaults(ItemID.IronBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，铅矿
                shop.item[nextSlot].SetDefaults(ItemID.LeadBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，银矿
                shop.item[nextSlot].SetDefaults(ItemID.SilverBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，钨矿
                shop.item[nextSlot].SetDefaults(ItemID.TungstenBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，金矿
                shop.item[nextSlot].SetDefaults(ItemID.GoldBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //设置商品，铂金矿
                shop.item[nextSlot].SetDefaults(ItemID.PlatinumBar);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：克苏鲁之眼
                if (NPC.downedBoss1)
                {
                    //设置商品，陨石
                    shop.item[nextSlot].SetDefaults(ItemID.Meteorite);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世界吞噬怪 & 克苏鲁之脑
                if (NPC.downedBoss2)
                {
                    //设置商品，魔矿
                    shop.item[nextSlot].SetDefaults(ItemID.DemoniteOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，猩红矿
                    shop.item[nextSlot].SetDefaults(ItemID.CrimtaneOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：骷髅王
                if (NPC.downedBoss3)
                {
                    //设置商品，黑曜石
                    shop.item[nextSlot].SetDefaults(ItemID.Obsidian);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，狱石
                    shop.item[nextSlot].SetDefaults(ItemID.Hellstone);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //*******************************************************

                //肉后

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //设置商品，钴矿
                    shop.item[nextSlot].SetDefaults(ItemID.CobaltOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，钯金矿
                    shop.item[nextSlot].SetDefaults(ItemID.PalladiumOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，秘银矿
                    shop.item[nextSlot].SetDefaults(ItemID.MythrilOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，山铜矿
                    shop.item[nextSlot].SetDefaults(ItemID.OrichalcumOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，精金矿
                    shop.item[nextSlot].SetDefaults(ItemID.AdamantiteOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //设置商品，钛金矿
                    shop.item[nextSlot].SetDefaults(ItemID.TitaniumOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 5000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //设置商品，叶绿矿
                    shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 10000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：月亮领主
                if (NPC.downedMoonlord)
                {
                    //设置商品，夜明矿
                    shop.item[nextSlot].SetDefaults(ItemID.LunarOre);
                    //设置价格：5金
                    shop.item[nextSlot].value = 20000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //***********************************************

                //琥珀
                shop.item[nextSlot].SetDefaults(ItemID.Amber);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //紫晶
                shop.item[nextSlot].SetDefaults(ItemID.Amethyst);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //黄玉
                shop.item[nextSlot].SetDefaults(ItemID.Topaz);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //蓝玉
                shop.item[nextSlot].SetDefaults(ItemID.Sapphire);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //翡翠
                shop.item[nextSlot].SetDefaults(ItemID.Emerald);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //红玉
                shop.item[nextSlot].SetDefaults(ItemID.Ruby);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //钻石
                shop.item[nextSlot].SetDefaults(ItemID.Diamond);
                //设置价格：5金
                shop.item[nextSlot].value = 10000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

            }

            //*******************************************************

            //	军火商，弹药
            if (type == NPCID.ArmsDealer)
            {
                //落星
                shop.item[nextSlot].SetDefaults(ItemID.FallenStar);
                //设置价格：5金
                shop.item[nextSlot].value = 200;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //*******************************************************

                //骨箭
                shop.item[nextSlot].SetDefaults(ItemID.BoneArrow);
                //设置价格：5金
                shop.item[nextSlot].value = 40;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //小丑之箭
                shop.item[nextSlot].SetDefaults(ItemID.JestersArrow);
                //设置价格：5金
                shop.item[nextSlot].value = 100;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：世界吞噬怪 & 克苏鲁之脑
                if (NPC.downedBoss2)
                {
                    //烈焰箭
                    shop.item[nextSlot].SetDefaults(ItemID.FlamingArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 200;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //霜冻箭
                    shop.item[nextSlot].SetDefaults(ItemID.FrostburnArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 200;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //狱炎箭
                    shop.item[nextSlot].SetDefaults(ItemID.HellfireArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 200;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //圣箭
                    shop.item[nextSlot].SetDefaults(ItemID.HolyArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //诅咒箭
                    shop.item[nextSlot].SetDefaults(ItemID.CursedArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //灵液箭
                    shop.item[nextSlot].SetDefaults(ItemID.IchorArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //毒液箭
                    shop.item[nextSlot].SetDefaults(ItemID.VenomArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //叶绿箭
                    shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 400;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：月亮领主
                if (NPC.downedMoonlord)
                {
                    //夜明箭
                    shop.item[nextSlot].SetDefaults(ItemID.MoonlordArrow);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //*******************************************************

                //打败：世界吞噬怪 & 克苏鲁之脑
                if (NPC.downedBoss2)
                {
                    //流星弹
                    shop.item[nextSlot].SetDefaults(ItemID.MeteorShot);
                    //设置价格：5金
                    shop.item[nextSlot].value = 200;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：击败肉山进入困难模式
                if (Main.hardMode)
                {
                    //爆破弹
                    shop.item[nextSlot].SetDefaults(ItemID.ExplodingBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //金子弹
                    shop.item[nextSlot].SetDefaults(ItemID.GoldenBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //高射速子弹
                    shop.item[nextSlot].SetDefaults(ItemID.HighVelocityBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //纳米弹
                    shop.item[nextSlot].SetDefaults(ItemID.NanoBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //派对弹
                    shop.item[nextSlot].SetDefaults(ItemID.PartyBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //毒液弹
                    shop.item[nextSlot].SetDefaults(ItemID.VenomBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //水晶子弹
                    shop.item[nextSlot].SetDefaults(ItemID.CrystalBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //诅咒弹
                    shop.item[nextSlot].SetDefaults(ItemID.CursedBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //灵液弹
                    shop.item[nextSlot].SetDefaults(ItemID.IchorBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //叶绿弹
                    shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 400;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：月亮领主
                if (NPC.downedMoonlord)
                {
                    //夜明弹
                    shop.item[nextSlot].SetDefaults(ItemID.MoonlordBullet);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }
            }

            //*******************************************************

            //	巫师，魔力药水、增益药水
            if (type == NPCID.Wizard)
            {
                //超级魔力药水
                shop.item[nextSlot].SetDefaults(ItemID.SuperManaPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //*******************************************************

                //弹药储备药水
                shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
                
                //箭术药水
                shop.item[nextSlot].SetDefaults(ItemID.ArcheryPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //战斗药水
                shop.item[nextSlot].SetDefaults(ItemID.BattlePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //魔能药水
                shop.item[nextSlot].SetDefaults(ItemID.MagicPowerPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //暴怒药水
                shop.item[nextSlot].SetDefaults(ItemID.RagePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //召唤药水
                shop.item[nextSlot].SetDefaults(ItemID.SummoningPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //泰坦药水
                shop.item[nextSlot].SetDefaults(ItemID.TitanPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //怒气药水
                shop.item[nextSlot].SetDefaults(ItemID.WrathPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //镇静药水
                shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //耐力药水
                shop.item[nextSlot].SetDefaults(ItemID.EndurancePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //拾心药水
                shop.item[nextSlot].SetDefaults(ItemID.HeartreachPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //狱火药水
                shop.item[nextSlot].SetDefaults(ItemID.InfernoPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //隐身药水
                shop.item[nextSlot].SetDefaults(ItemID.InvisibilityPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //生命力药水
                shop.item[nextSlot].SetDefaults(ItemID.LifeforcePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //荆棘药水
                shop.item[nextSlot].SetDefaults(ItemID.ThornsPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //保暖药水
                shop.item[nextSlot].SetDefaults(ItemID.WarmthPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //夜猫子药水
                shop.item[nextSlot].SetDefaults(ItemID.NightOwlPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //光芒药水
                shop.item[nextSlot].SetDefaults(ItemID.ShinePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //建筑工药水
                shop.item[nextSlot].SetDefaults(ItemID.BuilderPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //挖矿药水
                shop.item[nextSlot].SetDefaults(ItemID.MiningPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //钓鱼药水
                shop.item[nextSlot].SetDefaults(ItemID.FishingPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //声纳药水
                shop.item[nextSlot].SetDefaults(ItemID.SonarPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //宝匣药水
                shop.item[nextSlot].SetDefaults(ItemID.CratePotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //弱效幸运药水
                shop.item[nextSlot].SetDefaults(ItemID.LuckPotionLesser);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //幸运药水
                shop.item[nextSlot].SetDefaults(ItemID.LuckPotion);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //强效幸运药水
                shop.item[nextSlot].SetDefaults(ItemID.LuckPotionGreater);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
            }

            //*******************************************************

            //巫医，肉前掉落物
            if (type == NPCID.WitchDoctor)
            {
                //蚁狮上颚
                shop.item[nextSlot].SetDefaults(ItemID.AntlionMandible);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //凝胶
                shop.item[nextSlot].SetDefaults(ItemID.Gel);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //粉凝胶
                shop.item[nextSlot].SetDefaults(ItemID.PinkGel);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //晶状体
                shop.item[nextSlot].SetDefaults(ItemID.Lens);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //黑晶状体
                shop.item[nextSlot].SetDefaults(ItemID.BlackLens);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //腐肉
                shop.item[nextSlot].SetDefaults(ItemID.RottenChunk);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //椎骨
                shop.item[nextSlot].SetDefaults(ItemID.Vertebrae);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //蠕虫毒牙
                shop.item[nextSlot].SetDefaults(ItemID.WormTooth);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：克苏鲁之眼
                if (NPC.downedBoss1)
                {
                    //暗影鳞片
                    shop.item[nextSlot].SetDefaults(ItemID.ShadowScale);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //组织样本
                    shop.item[nextSlot].SetDefaults(ItemID.TissueSample);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //爪钩
                shop.item[nextSlot].SetDefaults(ItemID.Hook);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //藤蔓
                shop.item[nextSlot].SetDefaults(ItemID.Vine);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //丛林孢子
                shop.item[nextSlot].SetDefaults(ItemID.JungleSpores);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //毒刺
                shop.item[nextSlot].SetDefaults(ItemID.Stinger);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：蜂王
                if (NPC.downedQueenBee)
                {
                    //蜂蜡
                    shop.item[nextSlot].SetDefaults(ItemID.BeeWax);
                    //设置价格：5金
                    shop.item[nextSlot].value = 1000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //鲨鱼鳍
                shop.item[nextSlot].SetDefaults(ItemID.SharkFin);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //破布
                shop.item[nextSlot].SetDefaults(ItemID.TatteredCloth);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //骨头
                shop.item[nextSlot].SetDefaults(ItemID.Bone);
                //设置价格：5金
                shop.item[nextSlot].value = 500;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //羽毛
                shop.item[nextSlot].SetDefaults(ItemID.Feather);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

            }

            //*******************************************************

            //松露人，肉后掉落物
            if (type == NPCID.Truffle)
            {
                //蝴蝶尘
                shop.item[nextSlot].SetDefaults(ItemID.ButterflyDust);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //妖精尘
                shop.item[nextSlot].SetDefaults(ItemID.PixieDust);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //蜘蛛牙
                shop.item[nextSlot].SetDefaults(ItemID.SpiderFang);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //寒霜核
                shop.item[nextSlot].SetDefaults(ItemID.FrostCore);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //海龟壳
                shop.item[nextSlot].SetDefaults(ItemID.TurtleShell);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //独角兽角
                shop.item[nextSlot].SetDefaults(ItemID.UnicornHorn);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //光明之魂
                shop.item[nextSlot].SetDefaults(ItemID.SoulofLight);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //暗影之魂
                shop.item[nextSlot].SetDefaults(ItemID.SoulofNight);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //飞翔之魂
                shop.item[nextSlot].SetDefaults(ItemID.SoulofFlight);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //诅咒焰
                shop.item[nextSlot].SetDefaults(ItemID.CursedFlame);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //光明碎块
                shop.item[nextSlot].SetDefaults(ItemID.LightShard);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //暗黑碎块
                shop.item[nextSlot].SetDefaults(ItemID.DarkShard);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //水晶碎块
                shop.item[nextSlot].SetDefaults(ItemID.CrystalShard);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //远古布匹
                shop.item[nextSlot].SetDefaults(ItemID.AncientCloth);
                //设置价格：5金
                shop.item[nextSlot].value = 1000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //打败：任何机械BOSS
                if (NPC.downedMechBossAny)
                {
                    //神圣锭
                    shop.item[nextSlot].SetDefaults(ItemID.HallowedBar);
                    //设置价格：5金
                    shop.item[nextSlot].value = 30000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：机械双子魔眼
                if (NPC.downedMechBoss1)
                {
                    //视域之魂
                    shop.item[nextSlot].SetDefaults(ItemID.SoulofSight);
                    //设置价格：5金
                    shop.item[nextSlot].value = 30000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：机械毁灭者
                if (NPC.downedMechBoss2)
                {
                    //恐惧之魂
                    shop.item[nextSlot].SetDefaults(ItemID.SoulofFright);
                    //设置价格：5金
                    shop.item[nextSlot].value = 30000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：机械骷髅王
                if (NPC.downedMechBoss3)
                {
                    //力量之魂
                    shop.item[nextSlot].SetDefaults(ItemID.SoulofMight);
                    //设置价格：5金
                    shop.item[nextSlot].value = 30000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //禁戒碎片
                    shop.item[nextSlot].SetDefaults(ItemID.AncientBattleArmorMaterial);
                    //设置价格：5金
                    shop.item[nextSlot].value = 30000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：世纪之花
                if (NPC.downedPlantBoss)
                {
                    //灵气
                    shop.item[nextSlot].SetDefaults(ItemID.Ectoplasm);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //日耀碑牌碎片
                    shop.item[nextSlot].SetDefaults(ItemID.LunarTabletFragment);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：神庙石巨人
                if (NPC.downedGolemBoss)
                {
                    //甲虫外壳
                    shop.item[nextSlot].SetDefaults(ItemID.BeetleHusk);
                    //设置价格：5金
                    shop.item[nextSlot].value = 50000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //断裂英雄剑
                    shop.item[nextSlot].SetDefaults(ItemID.BrokenHeroSword);
                    //设置价格：5金
                    shop.item[nextSlot].value = 300000;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }

                //打败：远古教徒
                if (NPC.downedAncientCultist)
                {
                    //日耀碎片
                    shop.item[nextSlot].SetDefaults(ItemID.FragmentSolar);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //星旋碎片
                    shop.item[nextSlot].SetDefaults(ItemID.FragmentVortex);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //星云碎片
                    shop.item[nextSlot].SetDefaults(ItemID.FragmentNebula);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;

                    //星尘碎片
                    shop.item[nextSlot].SetDefaults(ItemID.FragmentStardust);
                    //设置价格：5金
                    shop.item[nextSlot].value = 500;
                    //切换到下一栏，否则你的NPC只能卖一件物品
                    nextSlot++;
                }
            }

            //*******************************************************

            //海盗，鱼竿
            if (type == NPCID.Truffle)
            {
                //鱼饵投掷者，25%
                shop.item[nextSlot].SetDefaults(ItemID.BloodFishingRod);
                //设置价格
                shop.item[nextSlot].value = 50000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //玻璃钢钓竿，30%
                shop.item[nextSlot].SetDefaults(ItemID.FiberglassFishingPole);
                //设置价格
                shop.item[nextSlot].value = 100000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //甲虫钓竿，30%
                shop.item[nextSlot].SetDefaults(ItemID.ScarabFishingRod);
                //设置价格
                shop.item[nextSlot].value = 200000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //机械师钓竿，35%
                shop.item[nextSlot].SetDefaults(ItemID.MechanicsRod);
                //设置价格
                shop.item[nextSlot].value = 300000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //冤大头钓竿，40%
                shop.item[nextSlot].SetDefaults(ItemID.SittingDucksFishingRod);
                //设置价格
                shop.item[nextSlot].value = 400000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //熔线钓钩，45%
                shop.item[nextSlot].SetDefaults(ItemID.HotlineFishingHook);
                //设置价格
                shop.item[nextSlot].value = 500000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;

                //金钓竿，50%
                shop.item[nextSlot].SetDefaults(ItemID.GoldenFishingRod);
                //设置价格
                shop.item[nextSlot].value = 1000000;
                //切换到下一栏，否则你的NPC只能卖一件物品
                nextSlot++;
            }
        }
    }
}
