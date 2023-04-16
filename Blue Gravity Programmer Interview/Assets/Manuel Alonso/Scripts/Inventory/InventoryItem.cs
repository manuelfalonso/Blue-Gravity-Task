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


    private bool _initialized = false;


    public void Setup(ItemShop itemData)
    {
        _itemIcon.sprite = itemData.Icon;
        _itemPrice.text = itemData.SellPrice.ToString();
        _initialized = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_initialized)
            _hoverMenu?.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_initialized)
            _hoverMenu?.SetActive(false);
    }
}
