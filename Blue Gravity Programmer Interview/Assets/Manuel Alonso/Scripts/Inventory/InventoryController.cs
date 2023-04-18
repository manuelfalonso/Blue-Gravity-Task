using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.Events;

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

    [Header("Events")]
    public UnityEvent<ItemShop> OnItemSold = new UnityEvent<ItemShop>();


    void Start()
    {
        _moneyPocketText.text = _playerData.InitialMoney.ToString();
    }


    // Called from Unity Event
    public void AddItemToInventory(ItemShop itemData)
    {
        bool isSuccess = false;

        foreach (var item in _items)
        {
            if (item.IsInitialized) continue;
            item.Setup(itemData);
            isSuccess = true;
            break;
        }

        if (!isSuccess)
            Debug.Log($"Inventory Full");
    }

    // Called from Unity Event
    public void RemoveItemFromInventory(ItemShop itemData)
    {
        bool isSuccess = false;

        foreach (var item in _items)
        {
            if (!item.IsInitialized) continue;
            if (item.Data.Id != itemData.Id) continue;
            OnItemSold?.Invoke(item.Data);
            item.ResetItem();
            isSuccess = true;
            break;
        }

        if (!isSuccess)
            Debug.Log($"Item in Inventory not found");
    }

    // Called from Unity Event
    public void SetMoneyPocketAmount(int amount)
    {
        _moneyPocketText.text = amount.ToString();
    }
}
