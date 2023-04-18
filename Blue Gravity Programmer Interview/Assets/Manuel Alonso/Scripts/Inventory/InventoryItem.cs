using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class InventoryItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField]
    private GameObject _hoverMenu = default(GameObject);

    [Header("Data")]
    [SerializeField]
    private Image _itemIcon = default;
    [SerializeField]
    private TextMeshProUGUI _itemPrice;

    [Header("Events")]
    public UnityEvent<ItemShop> OnClickToSell = new UnityEvent<ItemShop>();


    public ItemShop Data { get; private set; }
    public bool IsInitialized { get; private set; }


    public void Setup(ItemShop itemData)
    {
        _itemIcon.sprite = itemData.Icon;
        _itemPrice.text = itemData.SellPrice.ToString();
        Data = itemData;
        IsInitialized = true;
    }

    public void ResetItem()
    {
        _itemIcon.sprite = null;
        _itemPrice.text = string.Empty;
        Data = null;
        IsInitialized = false;
    }

    // Called from UI interaction
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (IsInitialized)
            _hoverMenu?.SetActive(true);
    }

    // Called from UI interaction
    public void OnPointerExit(PointerEventData eventData)
    {
        if (_hoverMenu.activeSelf) _hoverMenu.SetActive(false);
    }

    // Called from UI interaction
    public void OnPointerDown(PointerEventData eventData)
    {
        if (IsInitialized)
            OnClickToSell?.Invoke(Data);
    }
}
