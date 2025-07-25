using My3DGame.Common;
using UnityEngine;
using My3DGame;

namespace My3DGame.ItemSystem
{
    /// <summary>
    /// 아이템 능력치를 관리하는 클래스
    /// 속성 : 아이템 속성, 능력값, 능력값의 최소값, 능력치의 최대값
    /// 기능 : 능력치 더하기, 능력치 생성하기
    /// </summary>
    
    [System.Serializable]
    public class ItemBuff : IModifier
    {
        #region Variables
        public CharacterAttribute stat;     //아이템 능력치의 속성
        public int value;                   //아이템 능력치
        [SerializeField] private int min;
        [SerializeField] private int max;

        #endregion

        #region Property
        public int Min => min;
        public int Max => max;
        #endregion

        #region Constructor
        public ItemBuff(int _min, int _max)
        {
            min = _min;
            max = _max;
            GenerateValue();
        }
        #endregion
        #region Custom Method
        private void GenerateValue()
        {
            value = Random.Range(min, max);
        }

        //매개변수로 추가해야되는 변수를 넘겨주고 결과를 받아온다
        //ItemBuff가 가진 value를 매개변수로 받은 값에 더해서 다시 결과 보내준다
        public void AddValue(ref int baseValue)
        {
            baseValue += value;
        }
        #endregion
    }

}
