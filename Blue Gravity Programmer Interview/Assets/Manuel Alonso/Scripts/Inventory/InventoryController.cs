using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyPocketText = default(TextMeshProUGUI);

    [Header("Data")]
    [SerializeField]
    private PlayerSO _playerData = default(PlayerSO);

    [Header("Inventory items")]
    [SerializeField]
    private List<InventoryItem> _items = new List<InventoryItem>();


    void Start()
    {
        _moneyPocketText.text = _playerData.InitialMoney.ToString();
    }


    public bool AddItemToInventory(ItemShop itemData)
    {
        bool isSuccess = false;

        foreach (var item in _items)
        {
            if (item.IsInitialized) continue;
            item.Setup(itemData);
            isSuccess = true;
        }

        if (!isSuccess)
            Debug.Log($"Inventory Full");

        return isSuccess;
    }

    // Called from Unity Event
    public void RemoveItemFromInventory(ItemShop itemData)
    {
        bool isSuccess = false;

        foreach (var item in _items)
        {
            if (item.Data.Id != itemData.Id) continue;
            item.ResetItem();
            isSuccess = true;
        }

        if (!isSuccess)
            Debug.Log($"Item in Inventory not found");

        //return isSuccess;
    }
}
