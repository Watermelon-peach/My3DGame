using UnityEngine;

namespace My3DGame.Common
{
    //이펙트 종류 enum값 정의
    public enum EffectType
    {
        None = -1,
        NORMAL,
    }

    //사운드 종류 enum값 정의
    public enum SoundType
    {
        None = -1,
        MUSIC,
        SFX,
    }

    //캐릭터 속성 enum값 정의
    public enum CharacterAttribute
    {
        Agility,
        Intelligent,
        Stamina,
        Strength,
        Health,
        Mana
    }

    //아이템 타입 enum값 정의
    public enum ItemType
    {
        None = -1,
        Helmet = 0,
        Chest = 1,
        Pants = 2,
        Boots = 3,
        Pauldrons = 4,
        Gloves = 5,
        LeftWeapon = 6,
        RightWeapon = 7,
        Food,
        Default,
    }
}
