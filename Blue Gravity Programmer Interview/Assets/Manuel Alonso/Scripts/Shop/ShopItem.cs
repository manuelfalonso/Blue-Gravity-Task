using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShopItem : MonoBehaviour
{
    [SerializeField]
    private Image _icon = default(Image);
    [SerializeField]
    private TextMeshProUGUI _priceText = default(TextMeshProUGUI);

    [Header("Events")]
    public UnityEvent OnBuyItem = new UnityEvent();
    public UnityEvent OnSellItem = new UnityEvent();

    private bool _isInitialized = false;


    public void Setup(ItemShop data)
    {
        _icon.sprite = data.Icon;
        _priceText.text = data.BuyPrice.ToString();
        _isInitialized = true;
    }

    public void Buy()
    {
        OnBuyItem?.Invoke();
    }

    public void Sell()
    {
        OnSellItem?.Invoke();
    }
}
