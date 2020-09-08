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
        };

        static public RegistSet[] REGISTSET_LIST = new RegistSet[] {
        new RegistSet("アトラス",
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
        new RegistSet("ベリアル",
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
        new RegistSet("ドラゴンガイア",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FIER),
                }
                ),
        new RegistSet("バラモス",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_SEALED),
                    new RegistGroupEntity(REGIST_FALL),
                    new RegistGroupEntity(REGIST_ILLUSION),
                    new RegistGroupEntity(REGIST_PALSY),
                }
                ),
        new RegistSet("キングヒドラ",
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
                }
                ),
        new RegistSet("キラーマジンガ",
                new RegistGroupEntity[] {
                    new RegistGroupEntity(REGIST_FALL),
                }
                ),
        new RegistSet("幻界の四諸侯",
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
            };
    }
}
