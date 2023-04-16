using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private GameObject _hoverMenu = default(GameObject);

    [Header("Data")]
    [SerializeField]
    private Image _itemIcon = default;
    [SerializeField]
    private TextMeshProUGUI _itemPrice;


    public bool IsInitialized { get; private set; }


    public void Setup(ItemShop itemData)
    {
        _itemIcon.sprite = itemData.Icon;
        _itemPrice.text = itemData.SellPrice.ToString();
        IsInitialized = true;
    }

    public void ResetItem()
    {
        _itemIcon.sprite = null;
        _itemPrice.text = string.Empty;
        IsInitialized = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (IsInitialized)
            _hoverMenu?.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (IsInitialized)
            _hoverMenu?.SetActive(false);
    }
}
