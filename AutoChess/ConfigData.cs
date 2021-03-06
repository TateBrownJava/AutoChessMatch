﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    /// <summary>
    /// 配置数据
    /// </summary>
    public class ConfigData
    {
        /// <summary>
        /// 所有羁绊
        /// </summary>
        public static string Addition { get; } = @"刺客,3,所有刺客10% 4倍伤害
刺客,6,所有刺客20% 4倍伤害
德鲁伊,2,2星可以2合1
德鲁伊,4,3星可以2合1
法师,3,对方所有魔抗-40
法师,6,对方所有魔抗-40
工匠,2,所有工匠恢复+10
工匠,4,所有工匠恢复+20
猎人,3,所有猎人攻击+25%
猎人,6,所有猎人攻击+35%
骑士,2,所有骑士25%概率减伤护盾
骑士,4,所有骑士35%概率减伤护盾
骑士,6,所有骑士45%概率减伤护盾
萨满,2,战斗开始变羊对方一单位6秒
术士,3,所有友方吸血20%
术士,6,所有友方吸血30%
矮人,1,自己攻击距离+300
地精,3,一个友方护甲+15 恢复+10
地精,6,所有地精护甲+15 恢复+10
精灵,3,所有精灵25%闪避
精灵,6,所有精灵25%闪避
巨魔,2,所有巨魔攻速+35
巨魔,4,所有友方攻速+35
龙,3,所有龙初始魔法+100
娜迦,2,所有友方魔抗+20
娜迦,4,所有友方魔抗+40
人类,2,所有人类攻击20%缴械3秒
人类,4,所有人类攻击25%缴械3秒
人类,6,所有人类攻击30%缴械3秒
兽人,2,所有兽人最大生命值+250
兽人,4,所有兽人最大生命值+350
亡灵,2,对方所有护甲-5
亡灵,4,对方所有护甲-7
野兽,2,友方所有攻击+10%
野兽,4,友方所有攻击+10%
野兽,6,友方所有攻击+20%
元素,2,所有元素被近战攻击时30%石化对方3秒
元素,4,所有友方被近战攻击时30%石化对方3秒
食人魔,1,自己最大生命值+10%
恶魔猎手,1,该棋子视为敌方的一个恶魔
恶魔猎手,2,所有友方恶魔为同一种类
恶魔,1,所有恶魔攻击+50%纯粹伤害(一种恶魔时)
战士,3,所有战士护甲+6
战士,6,所有战士护甲+8
战士,9,所有战士护甲+10
";
        /// <summary>
        /// 所有羁绊
        /// </summary>
        public static string ChessPieces { get; } = @"卓尔游侠,亡灵,,猎人,1,远,自己攻击和攻速+20/30/40
死亡骑士,亡灵,,骑士,3,近,护盾10秒 吸收及伤害100/150/200【12】
死灵法师,亡灵,,术士,4,远,475范围治疗及伤害100/150/200【5】
巫妖,亡灵,,法师,5,远,伤害200/300/400在600距离弹跳6/9/12次【10/8/6】
赏金猎人,地精,,刺客,1,近,飞镖300/500/700伤害【5】
发条技师,地精,,工匠,1,近,弹幕每0.7秒50/75/100伤害持续5秒【12/10/8】
修补匠,地精,,工匠,1,远,伤害200/300/400的导弹3枚【7/6/5】
伐木机,地精,,工匠,2,近,300范围伤害150/200/250【6/5/4】
炼金术士,地精,,术士,4,近,400范围伤害15/25/35酸雾10秒 护甲-5/8/11【10】
地精工程师,地精,,工匠,5,远,600范围伤害700/1100/1500炸药桶【10】
斧王,兽人,,战士,1,近,192范围嘲讽2/3/4秒 护甲+5/10/15【10】
兽王,兽人,,猎人,2,近,1500距离2把飞斧 每把伤害70/110/150 伤害加深10%/20%/30%【7】
剑圣,兽人,,战士,2,近,250范围每秒伤害50/100/150剑刃风暴5秒 魔免【12】
干扰者,兽人,,萨满,4,近,400/500/550范围沉默3/4/5秒 最大每秒伤害100/200/300【15/12/9】
魅惑魔女,野兽,,德鲁伊,1,远,每精灵每秒25治疗11秒 3/5/7个精灵【15】
巨牙海民,野兽,,战士,1,近,海象神拳300%/350%400%伤害【7】
狼人,野兽,人类,战士,3,近,生命加成20%/30%/40% 召唤两只狼【60】
剧毒术士,野兽,,术士,3,远,召唤1个魔法免疫的守卫【7】
沙王,野兽,,刺客,3,近,眩晕2秒穿刺 伤害150/250/350【12/10/8】
利爪德鲁伊,野兽,,德鲁伊,4,近,召唤熊【60】
暗影萨满,巨魔,,萨满,1,远,变羊4/6/8秒【10】
蝙蝠骑士,巨魔,,骑士,1,远,375范围燃油 持续20秒【3】
巫医,巨魔,,术士,2,远,弹弹乐伤害50/75/100眩晕1秒2/4/6次【10】
巨魔战将,巨魔,,战士,4,近,攻击目标时攻速+15/20/25最多6/9/12层
痛苦女王,恶魔,,刺客,2,远,425范围尖叫伤害250/350/450【6】
混沌骑士,恶魔,,骑士,2,近,眩晕目标1-2/3/4秒伤害50/100/150-200/300/400【5】
影魔,恶魔,,术士,3,远,伤害100/150/200的魂之挽歌【20】
末日使者,恶魔,,战士,4,近,禁用技能和物品20秒 每秒伤害60/90/120【10】
狙击手,矮人,,猎人,3,远,伤害400/600/800狙击【10】
矮人直升机,矮人,,工匠,5,远,600范围两发导弹 每发伤害200/300/400
鱼人守卫,娜迦,,战士,2,近,点灯20秒护甲-15/30/45【3】
鱼人夜行者,娜迦,,刺客,3,近,隐身4秒 每秒回血3%/6%/9%【10/8/6】
蛇发女妖,娜迦,,猎人,4,远,600/800/1000范围石化2/3/4秒 物理伤害+30%【20】
潮汐猎人,娜迦,,猎人,5,近,500/650/800范围眩晕2/2.5/3秒 伤害150/250/350【30】
精灵龙,龙,精灵,法师,2,远,发出魔法球伤害150/200/250【5/4/3】
冥界亚龙,龙,,刺客,3,远,毒镖5秒 每秒伤害150/250/350 攻速-40/60/80【10/7/4】
龙骑士,龙,人类,骑士,4,远,变龙 每秒20伤害5秒/300范围75%溅射/-30攻速【60】
水晶室女,人类,,法师,2,远,存活时800范围每2秒友方魔法恢复8/14/20
全能骑士,人类,,骑士,3,近,260范围治疗及伤害200/300/400【10】
秀逗魔法师,人类,,法师,3,远,单体伤害500/750/1000闪电【13/10/7】
海军上将,人类,,战士,4,近,伤害200/300/400 眩晕1.4幽灵船 40%/45%/50伤害延后10秒结算【10】
光之守卫,人类,,法师,4,远,蓄力冲击波最大伤害300/450/600【10】
敌法师,精灵,,恶魔猎手,1,近,攻击削蓝30/60/90 伤害为50%
树精卫士,精灵,,德鲁伊,2,近,每次伤害及治疗30/45/60种子 共7次【7】
月之骑士,精灵,,骑士,2,远,500范围弹射3/5/7次 每次伤害减少30%
先知,精灵,,德鲁伊,2,远,召唤1个树人【7】
风行者,精灵,,猎人,3,远,伤害400/600/800蓄力箭 20%伤害衰减【10】
幻影刺客,精灵,,刺客,3,近,10%概率暴击300%/450%/600%
圣堂刺客,精灵,,刺客,4,近,4/6/8次折光6秒 攻击+40/60/80【6】
闪电幽魂,元素,,法师,3,远,400/500/600范围100/200/300伤害 带减速【10】
谜团,元素,,术士,5,远,450范围每秒5%/7%/9%凋零10秒【20】
食人魔法师,食人魔,,法师,1,近,嗜血术攻速+30/40/50持续30秒【5】
变体精灵,元素,,刺客,2,远,无敌的破浪形态向前 伤害150/250/350【10/8/6】
小小,元素,,战士,1,近,投掷一个敌人 落地200范围伤害100/150/200并眩晕1.5/2/2.5秒【10/8/6】
灵魂守卫,恶魔,,恶魔猎手,3,近,变身 攻击距离+600 攻击+50/100/200 攻速+50/75/100【60】
";
    }
}
