using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace YueHaiTheMoreRecipes
{
    class CreateRecipe : ModItem
    {
        //工作台：WorkBenches
        //砧：Anvils
        //熔炉：熔炉
        //玻璃瓶：Bottles
        //恶魔/猩红祭坛：DemonAltar
        //工匠作坊：TinkerersWorkbench
        //固化机：Solidifier
        //织布机：Loom
        //水晶球：CrystalBall

        //设置物品合成信息
        public override void AddRecipes()
        {
            //创建材料组：肉前锭
            RecipeGroup Bar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "肉前锭", new int[]
            {
                //铜锭
                ItemID.CopperBar,
                //锡锭
                ItemID.TinBar,

                //铁锭
                ItemID.IronBar,
                //铅锭
                ItemID.LeadBar,

                //银锭
                ItemID.SilverBar,
                //钨锭
                ItemID.TungstenBar,

                //金锭
                ItemID.GoldBar,
                //铂金锭
                ItemID.PlatinumBar,

                //魔矿
                ItemID.DemoniteOre,
                //猩红矿
                ItemID.CrimtaneOre,

                //陨石
                ItemID.Meteorite,
                //狱石
                ItemID.Hellstone
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:Bar", Bar);

            //创建材料组：铜锭
            RecipeGroup CopperBar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "铜锭/锡锭", new int[]
            {
                //铜锭
                ItemID.CopperBar,
                //锡锭
                ItemID.TinBar
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:CopperBar", CopperBar);

            //创建材料组：铁锭
            RecipeGroup IronBar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "铁锭/铅锭", new int[]
            {

                //铁锭
                ItemID.IronBar,
                //铅锭
                ItemID.LeadBar
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:IronBar", IronBar);

            //创建材料组：银锭
            RecipeGroup SilverBar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "银锭/钨锭", new int[]
            {
                //银锭
                ItemID.SilverBar,
                //钨锭
                ItemID.TungstenBar
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:SilverBar", SilverBar);

            //创建材料组：金锭
            RecipeGroup GoldBar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "金锭/铂金锭", new int[]
            {
                //金锭
                ItemID.GoldBar,
                //铂金锭
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:GoldBar", GoldBar);

            //创建材料组：肉后锭
            RecipeGroup Ore = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "肉后锭", new int[]
            {
                //钴矿
                ItemID.CobaltOre,
                //钯金矿
                ItemID.PalladiumOre,

                //秘银矿
                ItemID.MythrilOre,
                //山铜矿
                ItemID.OrichalcumOre,

                //精金矿
                ItemID.AdamantiteOre,
                //钛金矿
                ItemID.TitaniumOre,

                //叶绿矿
                ItemID.ChlorophyteOre,
                //夜明矿
                ItemID.LunarOre
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:Ore", Ore);

            //创建材料组：魂
            RecipeGroup SoulofLightANDSoulofNight = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "光明之魂/暗影之魂", new int[]
            {
                //光明之魂
                ItemID.SoulofLight,
                //暗影之魂
                ItemID.SoulofNight
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:SoulofLightANDSoulofNight", SoulofLightANDSoulofNight);


            //创建材料组：鱼饵
            RecipeGroup Bait = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "学徒诱饵/熟手诱饵/大师诱饵", new int[]
            {
                //学徒诱饵
                ItemID.ApprenticeBait,
                //熟手诱饵
                ItemID.JourneymanBait,
                //大师诱饵
                ItemID.MasterBait
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:Bait", Bait);

            //创建材料组：腐肉/椎骨
            RecipeGroup RottenChunkANDVertebrae = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "腐肉/椎骨", new int[]
            {
                //腐肉
                ItemID.RottenChunk,
                //椎骨
                ItemID.Vertebrae
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:RottenChunkANDVertebrae", RottenChunkANDVertebrae);

            //创建材料组：黑檀石块/猩红石
            RecipeGroup EbonstoneBlockANDCrimstoneBlock = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "黑檀石块/猩红石块", new int[]
            {
                //黑檀石块
                ItemID.EbonstoneBlock,
                //猩红石块
                ItemID.CrimstoneBlock
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:EbonstoneBlockANDCrimstoneBlock", EbonstoneBlockANDCrimstoneBlock);


            //创建材料组：花
            RecipeGroup bloom = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "花", new int[]
            {
                //闪耀根
                ItemID.Blinkroot,
                //太阳花
                ItemID.Daybloom,
                //月光草
                ItemID.Moonglow,
                //寒颤棘
                ItemID.Shiverthorn,
                //幌菊
                ItemID.Waterleaf,
                //火焰花
                ItemID.Fireblossom,
                //死亡草
                ItemID.Deathweed
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:bloom", bloom);

            //创建材料组：木材
            RecipeGroup Wood = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "木材", new int[]
            {
                //木材
                ItemID.Wood,
                //乌木
                ItemID.Ebonwood,
                //红木
                ItemID.RichMahogany,
                //暗影木
                ItemID.Shadewood,
                //珍珠木
                ItemID.Pearlwood,
                //针叶木
                ItemID.BorealWood,
                //棕榈木
                ItemID.PalmWood,
                //阴森木
                ItemID.SpookyWood
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:Wood", Wood);

            //创建材料组：翅膀
            RecipeGroup wing = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "翅膀", new int[]
            {
                //喷气背包
                ItemID.Jetpack,
                //Lazure的屏障台
                ItemID.BejeweledValkyrieWing,
                //Yoraiz0r的魔法
                ItemID.Yoraiz0rWings,
                //Skiphs的爪子
                ItemID.SkiphsWings,
                //Leinfors的卷缠斗篷
                ItemID.LeinforsWings,
                //Safeman的毛毯斗篷
                ItemID.SafemanWings,
                //悬浮板
                ItemID.Hoverboard,
                //天界星盘
                ItemID.LongRainbowTrailWings,
                //Red的翅膀
                ItemID.RedsWings,
                //D-Town的翅膀
                ItemID.DTownsWings,
                //Will的翅膀
                ItemID.WillsWings,
                //Crowno的翅膀
                ItemID.CrownosWings,
                //Cenx的翅膀
                ItemID.CenxsWings,
                //Jim的翅膀
                ItemID.JimsWings,
                //Loki的翅膀
                ItemID.LokisWings,
                //Grox The Great的翅膀
                ItemID.GroxTheGreatWings,

                //*******************************************************

                //日耀之翼
                ItemID.WingsSolar,
                //星尘之翼
                ItemID.WingsStardust,
                //星旋强化翼
                ItemID.WingsVortex,
                //星云斗篷
                ItemID.WingsNebula,
                //恶魔之翼
                ItemID.DemonWings,
                //天使之翼
                ItemID.AngelWings,
                //蝴蝶之翼
                ItemID.ButterflyWings,
                //仙灵之翼
                ItemID.FairyWings,
                //鸟妖之翼
                ItemID.HarpyWings,
                //骨之翼
                ItemID.BoneWings,
                //烈焰之翼
                ItemID.FlameWings,
                //冰冻之翼
                ItemID.FrozenWings,
                //幽灵之翼
                ItemID.GhostWings,
                //蒸汽朋克之翼
                ItemID.SteampunkWings,
                //叶之翼
                ItemID.LeafWings,
                //蝙蝠之翼
                ItemID.BatWings,
                //蜜蜂之翼
                ItemID.BeeWings,
                //破蝙蝠之翼
                ItemID.BrokenBatWing,
                //破蝙蝠之翼
                ItemID.BrokenBatWing,
                //褴褛蜜蜂之翼
                ItemID.TatteredBeeWing,
                //褴褛仙灵之翼
                ItemID.TatteredFairyWings,
                //阴森之翼
                ItemID.SpookyWings,
                //喜庆之翼
                ItemID.FestiveWings,
                //甲虫之翼
                ItemID.BeetleWings,
                //鳍翼
                ItemID.FinWings,
                //猪龙鱼之翼
                ItemID.FishronWings,
                //蛾怪之翼
                ItemID.MothronWings,
                //双足翼龙之翼
                ItemID.BetsyWings,
                //Arkhalis的飞翼
                ItemID.ArkhalisWings,
                //Ghostar的无极翼
                ItemID.GhostarsWings,
                //FoodBarbarian的褴褛龙之翼
                ItemID.FoodBarbarianWings,
                //女皇之翼
                ItemID.RainbowWings,
                //雏翼
                ItemID.CreativeWings
            });
            RecipeGroup.RegisterGroup("ReducedGrinding:wing", wing);
            
            //***************************************************************

            Recipe recipe = CreateRecipe();

            //使用原版物品的合成配方：1个泥土，DirtBlock：泥土
            //recipe.AddIngredient(ItemID.DirtBlock, 1);
            //合成原版：天顶剑
            //recipe.ReplaceResult(ItemID.Zenith);
            //合成环境：工作台
            //recipe.AddTile(TileID.WorkBenches);
            //加入合成表,本物品合成结束
            //recipe.Register();

            //***************************************************************

            //个人数字助手

            //全球定位系统
            //深度计
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar",10);
            //合成原版深度计
            recipe.ReplaceResult(ItemID.DepthMeter);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //罗盘
            recipe = CreateRecipe();
            //合成配方：8个铜锭
            recipe.AddRecipeGroup("ReducedGrinding:CopperBar", 8);
            //合成配方：6个铁锭
            recipe.AddRecipeGroup("ReducedGrinding:IronBar", 6);
            //合成原版罗盘
            recipe.ReplaceResult(ItemID.Compass);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();


            //探鱼器
            //渔民袖珍宝典
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：20个学徒诱饵/熟手诱饵/大师诱饵
            recipe.AddRecipeGroup("ReducedGrinding:Bait", 20);
            //合成原版探鱼器
            recipe.ReplaceResult(ItemID.FishFinder);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //天气收音机
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：10个雨云
            recipe.AddIngredient(ItemID.RainCloud, 10);
            //合成原版天气收音机
            recipe.ReplaceResult(ItemID.WeatherRadio);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //六分仪
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：1个月光草
            recipe.AddIngredient(ItemID.Moonglow, 1);
            //合成原版六分仪
            recipe.ReplaceResult(ItemID.Sextant);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();


            //哥布林数据仪
            //金属探测器
            recipe = CreateRecipe();
            //合成配方：任意8个铜/锡锭
            recipe.AddRecipeGroup("ReducedGrinding:CopperBar", 8);
            //合成配方：任意6个铁/铅锭
            recipe.AddRecipeGroup("ReducedGrinding:IronBar", 6);
            //合成配方：任意4个银/钨锭
            recipe.AddRecipeGroup("ReducedGrinding:SilverBar", 4);
            //合成配方：任意2个金/铂金锭
            recipe.AddRecipeGroup("ReducedGrinding:GoldBar", 2);
            //合成原版金属探测器
            recipe.ReplaceResult(ItemID.MetalDetector);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //秒表
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：10根电线
            recipe.AddIngredient(ItemID.Wire, 10);
            //合成配方：1个开关
            recipe.AddIngredient(ItemID.Switch, 1);
            //合成原版秒表
            recipe.ReplaceResult(ItemID.Stopwatch);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //每秒伤害计数器
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：10根电线
            recipe.AddIngredient(ItemID.Wire, 10);
            //合成配方：1个开关
            recipe.AddIngredient(ItemID.Switch, 1);
            //合成原版每秒伤害计数器
            recipe.ReplaceResult(ItemID.DPSMeter);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();


            //R.E.K.3000
            //雷达
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：10根电线
            recipe.AddIngredient(ItemID.Wire, 10);
            //合成原版雷达
            recipe.ReplaceResult(ItemID.Radar);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //生命体分析机
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：1个生命水晶
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            //合成原版生命体分析机
            recipe.ReplaceResult(ItemID.LifeformAnalyzer);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //杀怪计数器
            recipe = CreateRecipe();
            //合成配方：任意10个肉前锭
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：10根电线
            recipe.AddIngredient(ItemID.Wire, 10);
            //合成配方：1个开关
            recipe.AddIngredient(ItemID.Switch, 1);
            //合成原版杀怪计数器
            recipe.ReplaceResult(ItemID.TallyCounter);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //***************************************************************

            //魔镜 任意5个肉前锭，10个玻璃
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Glass, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.MagicMirror);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //皮革      腐肉/脊椎骨
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:RottenChunkANDVertebrae", 5);
            //合成原版
            recipe.ReplaceResult(ItemID.Leather);
            //合成环境：铁砧
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //赫尔墨斯靴 任意8个肉前锭，5个皮革，2个羽毛
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 8);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Feather, 2);
            //合成原版
            recipe.ReplaceResult(ItemID.HermesBoots);
            //合成环境：铁砧
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //疾风脚镯 任意5个肉前锭，5个丛林孢子
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.AnkletoftheWind);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //金属扣带        8个铁 / 铅，4个金 / 铂金锭
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:IronBar", 8);
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:GoldBar", 4);
            //合成原版
            recipe.ReplaceResult(ItemID.Aglet);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //溜冰鞋 任意10个肉前锭，5个皮革，	
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.IceSkates);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //幸运马掌 任意10个肉前锭，10个云
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 10);
            //合成配方：
            recipe.AddIngredient(ItemID.Cloud, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.LuckyHorseshoe);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //闪亮红气球       5个皮革，1个红染料
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.RedDye, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.ShinyRedBalloon);
            //合成环境：铁砧
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //大自然的恩赐 任意1个花，10个堕落之星
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:bloom", 1);
            //合成配方：
            recipe.AddIngredient(ItemID.FallenStar, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.NaturesGift);
            //合成环境：铁砧
            recipe.AddTile(TileID.Bottles);
            //加入合成表,本物品合成结束
            recipe.Register();

            //恐慌项链        10个猩红石 / 10个黑檀石块
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:EbonstoneBlockANDCrimstoneBlock", 10);
            //合成原版
            recipe.ReplaceResult(ItemID.PanicNecklace);
            //合成环境：铁砧
            recipe.AddTile(TileID.DemonAltar);
            //加入合成表,本物品合成结束
            recipe.Register();

            //再生手环 任意5个肉前锭，1个生命水晶
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.BandofRegeneration);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //月光护身符 任意5个肉后锭，5个坠落之星
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Ore", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.FallenStar, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.MoonCharm);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //海神贝壳 恐惧之魂10，珊瑚15，鲨鱼鳍5，光明之魂10，暗影之魂10
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Coral, 15);
            //合成配方：
            recipe.AddIngredient(ItemID.SharkFin, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            //合成配方：
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            //合成配方：
            recipe.AddIngredient(ItemID.SoulofFright, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.NeptunesShell);
            //合成环境：水晶球
            recipe.AddTile(TileID.CrystalBall);
            //加入合成表,本物品合成结束
            recipe.Register();

            //星星斗篷        5个皮革，5个堕落之星
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.FallenStar, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.StarCloak);
            //合成环境：玻璃瓶
            recipe.AddTile(TileID.Bottles);
            //加入合成表,本物品合成结束
            recipe.Register();

            //十字项链 任意5个肉前锭，1个黄玉
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Topaz, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.CrossNecklace);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //黑曜石水上漂靴 赫尔墨斯靴，10个黑曜石
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.HermesBoots, 1);
            //合成配方：
            recipe.AddIngredient(ItemID.Obsidian, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.ObsidianWaterWalkingBoots);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //熔岩护身符       10个狱石锭，10个黑曜石
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            //合成配方：
            recipe.AddIngredient(ItemID.Obsidian, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.LavaCharm);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //鞋钉 任意5个肉前锭，3个皮革
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 3);
            //合成原版
            recipe.ReplaceResult(ItemID.ShoeSpikes);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //攀爬爪 任意5个肉前锭，3个皮革
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 3);
            //合成原版
            recipe.ReplaceResult(ItemID.ClimbingClaws);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //分趾厚底袜       5个皮革，10个丝绸
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Silk, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.Tabi);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //黑腰带     5个皮革，10个丝绸
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Silk, 10);
            //合成配方：
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.BlackBelt);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //云朵瓶     1个玻璃瓶，10个云
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Bottle, 1);
            //合成配方：
            recipe.AddIngredient(ItemID.Cloud, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.CloudinaBottle);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //沙暴瓶     1个玻璃瓶，10个沙块
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Bottle, 1);
            //合成配方：
            recipe.AddIngredient(ItemID.SandBlock, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.SandstorminaBottle);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //暴雪瓶     1个玻璃瓶，10个雪块
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Bottle, 1);
            //合成配方：
            recipe.AddIngredient(ItemID.SnowBlock, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.BlizzardinaBottle);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //海啸瓶     5个水瓶
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.BottledWater, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.TsunamiInABottle);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //岩浆石     10个狱石
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.Hellstone, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.MagmaStone);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //水母项链 任意5个肉前锭，1个红宝石
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Ruby, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.JellyfishNecklace);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //潜水头盔 任意5个肉前锭，5个鲨鱼鳍
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.SharkFin, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.DivingHelmet);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //脚蹼 任意5个肉前锭，5个皮革
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.Flipper);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();

            //死灵卷轴 阴森木50个
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.SpookyWood, 50);
            //合成原版
            recipe.ReplaceResult(ItemID.NecromanticScroll);
            //合成环境：水晶球
            recipe.AddTile(TileID.CrystalBall);
            //加入合成表,本物品合成结束
            recipe.Register();

            //泰坦手套 任意5个肉后锭，5个光明魂 / 黑暗魂
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Ore", 5);
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:SoulofLightANDSoulofNight", 5);
            //合成原版
            recipe.ReplaceResult(ItemID.TitanGlove);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //猛爪手套 任意5个肉前锭，5个丛林孢子
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Bar", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.FeralClaws);
            //合成环境：铁砧
            recipe.AddTile(TileID.Anvils);
            //加入合成表,本物品合成结束
            recipe.Register();

            //血肉指虎 任意5个肉后锭，20个猩红石 / 黑檀石块
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Ore", 5);
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:EbonstoneBlockANDCrimstoneBlock", 20);
            //合成原版
            recipe.ReplaceResult(ItemID.FleshKnuckles);
            //合成环境：恶魔/猩红祭坛：
            recipe.AddTile(TileID.DemonAltar);
            //加入合成表,本物品合成结束
            recipe.Register();

            //腐香囊 任意5个肉后锭，20个猩红石 / 黑檀石块
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Ore", 5);
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:EbonstoneBlockANDCrimstoneBlock", 20);
            //合成原版
            recipe.ReplaceResult(ItemID.MagicMirror);
            //合成环境：恶魔/猩红祭坛：
            recipe.AddTile(TileID.DemonAltar);
            //加入合成表,本物品合成结束
            recipe.Register();

            //魔法箭袋        任意5个肉后锭,99个木箭，5个皮革，5个堕落之星
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:Ore", 5);
            //合成配方：
            recipe.AddIngredient(ItemID.WoodenArrow, 99);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 5);
            //合成配方：
            recipe.AddIngredient(ItemID.FallenStar, 5);
            //合成原版
            recipe.ReplaceResult(ItemID.MagicQuiver);
            //合成环境：水晶球
            recipe.AddTile(TileID.CrystalBall);
            //加入合成表,本物品合成结束
            recipe.Register();
            
            /*
             **********************************************************************************
             */

            //巫士徽章
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.WallOfFleshBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.SorcererEmblem);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //召唤师徽章
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.WallOfFleshBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.SummonerEmblem);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //战士徽章
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.WallOfFleshBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.WarriorEmblem);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //游侠徽章
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.WallOfFleshBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.RangerEmblem);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //锯刃镐
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.GolemBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.Picksaw);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //彩虹光标
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddIngredient(ItemID.FairyQueenBossBag, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.RainbowCursor);
            //合成环境：固化机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //月亮领主腿
            recipe = CreateRecipe(); 
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:RottenChunkANDVertebrae", 10);
            //合成配方：
            recipe.AddIngredient(ItemID.Leather, 10);
            //合成原版
            recipe.ReplaceResult(ItemID.MoonLordLegs);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();


            /*
             **********************************************************************************
             */

            //天界星盘
            recipe = CreateRecipe();
            //合成配方：
            recipe.AddRecipeGroup("ReducedGrinding:wing", 1);
            //合成配方：
            recipe.AddIngredient(ItemID.EmpressFlightBooster, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.MoonLordLegs);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();


            /*
             **********************************************************************************
             */

            //事件掉落

            //火星暴乱
            recipe = CreateRecipe();
            //合成配方：火星飞碟圣物
            recipe.AddIngredient(ItemID.UFOMasterTrophy, 1);
            //合成原版：宇宙车钥匙
            recipe.ReplaceResult(ItemID.CosmicCarKey);
            //合成环境：织布机
            recipe.AddTile(TileID.Solidifier);
            //加入合成表,本物品合成结束
            recipe.Register();

            //海盗入侵
            recipe = CreateRecipe();
            //合成配方：荷兰飞盗船圣物
            recipe.AddIngredient(ItemID.FlyingDutchmanMasterTrophy, 1);
            //合成原版
            recipe.ReplaceResult(ItemID.PirateShipMountItem);
            //合成环境：织布机
            recipe.AddTile(TileID.Loom);
            //加入合成表,本物品合成结束
            recipe.Register();
            
        }

    }
}
