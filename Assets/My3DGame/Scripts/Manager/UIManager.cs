using UnityEngine;
using My3DGame.ItemSystem;
using My3DGame.InventorySystem;
using My3DGame.Util;

namespace My3DGame.Manager
{
    /// <summary>
    /// 게임 플레이중 UI를 관리하는 클래스
    /// </summary>
    public class UIManager : Singleton<UIManager>
    {
        #region Variables
        public ItemDataBase itemDataBase;
        public InventorySO inventoryObject;

        public DynamicInventoryUI playerInventoryUI;
        public StaticInventoryUI playerEquipmentUI;

        public int index = 2;
        #endregion

        #region Unity Event Method
        protected override void Awake()
        {
            base.Awake();

            //update select 이벤트 함수 등록
            playerInventoryUI.OnUpdateSelectslot += playerEquipmentUI.UpdateSelectSlot;
            playerEquipmentUI.OnUpdateSelectslot += playerInventoryUI.UpdateSelectSlot;
        }

        private void Update()
        {
            //
            if (Input.GetKeyDown(KeyCode.I))
            {
                TogglePlayerInventoryUI();
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                TogglePlayerEquipmentUI();
            }

            //치트키
            if (Input.GetKeyDown(KeyCode.M))
            {
                Item newItem = itemDataBase.itemObjects[index].CreateItem();
                inventoryObject.AddItem(newItem, 1);
            }
        }
        #endregion

        #region Custom Method
        private void Toggle(GameObject go)
        {
            go.SetActive(!go.activeSelf);
        }

        public void TogglePlayerInventoryUI()
        {
            Toggle(playerInventoryUI.gameObject);
        }

        public void TogglePlayerEquipmentUI()
        {
            Toggle(playerEquipmentUI.gameObject);
        }

        //인벤토리에 아이템 추가
        public bool AddItemInventory(Item newItem, int amount)
        {
            return inventoryObject.AddItem(newItem, amount);
        }
        #endregion
    }

}
