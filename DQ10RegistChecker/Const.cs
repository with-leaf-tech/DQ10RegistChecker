using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10RegistChecker {
    static public class Const {
        static public string PARTS_HEAD = "アタマ";
        static public string PARTS_UPBODY = "体上";
        static public string PARTS_LOWBODY = "体下";
        static public string PARTS_LEG = "足";
        static public string PARTS_OTHER = "その他";

        static public (string name, string[] parts, int count) REGIST_PALSY = ("マヒ", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_CONFUSE = ("混乱", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_SEALED = ("封印", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_ILLUSION = ("幻惑", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_POISON = ("毒", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_SLEEP = ("眠り", new string[] { PARTS_HEAD, PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_DEATH = ("即死", new string[] { PARTS_HEAD, PARTS_UPBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_CURSE = ("呪い", new string[] { PARTS_UPBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_MPDRAIN = ("MP吸収", new string[] { PARTS_LOWBODY }, 2);
        static public (string name, string[] parts, int count) REGIST_FALL = ("転び", new string[] { PARTS_LEG }, 1);
        static public (string name, string[] parts, int count) REGIST_DANCE = ("踊り", new string[] { PARTS_LEG }, 1);
        static public (string name, string[] parts, int count) REGIST_FIER = ("おびえ", new string[] { PARTS_HEAD }, 1);

        static public (string name, string[] parts, int count) REGIST_CHARM = ("魅了", new string[] { PARTS_OTHER }, 1);
        static public (string name, string[] parts, int count) REGIST_BIND = ("しばり", new string[] { PARTS_OTHER }, 1);

        static public (string name, string[] parts, int count)[] REGIST_LIST = new (string name, string[] parts, int count)[] {
            REGIST_PALSY,
            REGIST_CONFUSE,
            REGIST_SEALED,
            REGIST_ILLUSION,
            REGIST_POISON,
            REGIST_SLEEP,
            REGIST_DEATH,
            REGIST_CURSE,
            REGIST_MPDRAIN,
            REGIST_FALL,
            REGIST_DANCE,
            REGIST_FIER,
            REGIST_CHARM,
            REGIST_BIND,
        };

        static public RegistSet[] REGISTSET_LIST = new RegistSet[] {
        new RegistSet("アトラス",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("アトラス強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("バズズ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_SLEEP),
                }
                ),
        new RegistSet("バズズ強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_BIND),
                }
                ),
        new RegistSet("ベリアル",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("ベリアル強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("悪霊の神々",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("悪霊の神々強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("ドラゴンガイア強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("バラモス",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("バラモス強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("キングヒドラ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("キングヒドラ強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("グラコス",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("グラコス強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("伝説の三悪魔",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("キラーマジンガ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("キラーマジンガ強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("幻界の四諸侯",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("幻界の四諸侯強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("ドン・モグーラ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("暗黒の魔人",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("タロット魔人",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("タロット魔人強",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("死神スライダーク",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_DEATH),
                }
                ),
        new RegistSet("ギュメイ将軍",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("ゲルニック将軍",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_ILLUSION),
                }
                ),
        new RegistSet("ゴレオン将軍",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                }
                ),
        new RegistSet("帝国三将軍",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_ILLUSION),
                }
                ),
        new RegistSet("魔犬レオパルド",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("プチゴースネル",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_POISON),
                }
                ),
        new RegistSet("牙王ゴースネル",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_POISON),
                }
                ),
        new RegistSet("輪王ザルトラ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_CURSE),
                }
                ),
        new RegistSet("剣王ガルドリオン",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("震王ジュノーガ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_DEATH),
                }
                ),
        new RegistSet("常闇の竜レグナード",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                }
                ),
        new RegistSet("ダークキング",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_POISON),
                }
                ),
        new RegistSet("海冥主メイヴ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                }
                ),
        new RegistSet("レギルラッゾ&ローガスト",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("紅殻魔スコルパイド",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_SEALED),
                }
                ),
        new RegistSet("翠将鬼ジェルザーク",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_DANCE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("剛獣鬼ガルドドン",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE), 
                }
                ),
        new RegistSet("輝晶獣ゾルゾム",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),    
                }
                ),
        new RegistSet("輝晶獣ボイボゥ",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL), 
                }
                ),
        new RegistSet("輝晶獣ドグドラ",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),    
                }
                ),
        new RegistSet("災いの神話と暴虐の悪夢",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_DEATH),  
                }
                ),
        new RegistSet("闇に落ちた英雄の幻影",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FIER),    
                }
                ),
        new RegistSet("覇道の双璧",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY), 
                }
                ),
        new RegistSet("魔幻の覇王軍一獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("魔幻の覇王軍二獄四獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_FIER),   
                }
                ),
        new RegistSet("魔幻の覇王軍三獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_FIER),    
                }
                ),
        new RegistSet("魔幻の最高幹部",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),    
                }
                ),
        new RegistSet("妖女と災獣",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FIER),   
                }
                ),
        new RegistSet("破壊と創造の神々",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_DEATH),    
                }
                ),
        new RegistSet("背離する魔幻の血統",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),  
                }
                ),
        new RegistSet("魔宮の守護者たち一獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("魔宮の守護者たち二獄四獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),    
                }
                ),
        new RegistSet("魔宮の守護者たち三獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),  
                }
                ),
        new RegistSet("昏き悪夢の衝撃",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_DEATH), 
                }
                ),
        new RegistSet("災厄神話ギャラリー一獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("災厄神話ギャラリー二獄四獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),    
                }
                ),
        new RegistSet("災厄神話ギャラリー三獄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_FIER),    
                }
                ),
        new RegistSet("覇業の君臣",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_POISON),   
                }
                ),
        new RegistSet("悲劇の英雄譚",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_ILLUSION),   
                }
                ),
        new RegistSet("見果てぬ夢の蛮勇",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FIER),
                    new RegistGroupEntity(REGIST_DEATH),  
                }
                ),
        new RegistSet("炎と氷の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),   
                }
                ),
        new RegistSet("水と嵐の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),    
                }
                ),
        new RegistSet("炎と闇の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_POISON),   
                }
                ),
        new RegistSet("闇と水の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_SLEEP),    
                }
                ),
        new RegistSet("氷と嵐の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),   
                }
                ),
        new RegistSet("炎と嵐の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),   
                }
                ),
        new RegistSet("氷と水の災禍",
                new RegistGroupEntity[] {  
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),    
                }
                ),
        new RegistSet("闇と嵐の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_POISON),  
                }
                ),
        new RegistSet("氷と闇の災禍",
                new RegistGroupEntity[] {  
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_POISON),    
                }
                ),
        new RegistSet("炎と水の災禍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_POISON),    
                }
                ),
        new RegistSet("冥府より来たるもの",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_SLEEP),   
                }
                ),
        new RegistSet("復讐の兄弟竜",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FIER), 
                }
                ),
        new RegistSet("真紅の殺人機械たち",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_CURSE), 
                }
                ),
        new RegistSet("暗黒の星竜機",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),    
                }
                ),
        new RegistSet("絶牙の白獅子たち",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FIER), 
                }
                ),
        new RegistSet("邪竜神の使徒たち",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_FALL),    
                }
                ),
        new RegistSet("虚空の邪竜神",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),   
                }
                ),
        new RegistSet("黒竜と白獅子",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("炎界に潜む脅威",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_FALL),   
                }
                ),
        new RegistSet("旧災厄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),   
                }
                ),
        new RegistSet("真災厄",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),   
                }
                ),
        new RegistSet("ダークドレアム",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_DEATH), 
                }
                ),
        new RegistSet("やさい三銃士",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_ILLUSION),  
                }
                ),
        new RegistSet("闇朱の獣牙兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_FIER),  
                }
                ),
        new RegistSet("紫炎の鉄機兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL), 
                }
                ),
        new RegistSet("深碧の造魔兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),   
                }
                ),
        new RegistSet("蒼怨の屍獄兵団",
                new RegistGroupEntity[] {  
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_PALSY), 
                }
                ),
        new RegistSet("銀甲の凶蟲兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_BIND),
                }
                ),
        new RegistSet("翠煙の海妖兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_CONFUSE),
                    new RegistGroupEntity(REGIST_SEALED), 
                }
                ),
        new RegistSet("灰塵の竜鱗兵団",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FALL), 
                }
                ),
        new RegistSet("異星からの侵略軍",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_CHARM),
                }
                ),
        new RegistSet("一の災壇",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_DEATH),
                    new RegistGroupEntity(REGIST_CURSE),
                    new RegistGroupEntity(REGIST_MPDRAIN),
                }
                ),
        new RegistSet("二の災壇",
                new RegistGroupEntity[] {   
                    new RegistGroupEntity(REGIST_PALSY),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_POISON),
                    new RegistGroupEntity(REGIST_MPDRAIN),
                }
                ),
        new RegistSet("三の災壇",
                new RegistGroupEntity[] {  
                    new RegistGroupEntity(REGIST_SLEEP),
                    new RegistGroupEntity(REGIST_ILLUSION),
                }
                ),
        };
    }
}
