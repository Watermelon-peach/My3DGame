using System;
using UnityEngine;

namespace My3DGame.ItemSystem
{
    /// <summary>
    /// 아이템 데이터를 관리하는 클래스
    /// 속성: 아이디(아이템 데이터베이스 아이디), 이름, 능력치
    /// </summary>
    [Serializable]
    public class Item
    {
        #region Variables
        public int id;
        public string name;
        #endregion


        #region Constructor
        public Item()
        {
            id = -1;
            name = null;
        }
        #endregion
    }

}
