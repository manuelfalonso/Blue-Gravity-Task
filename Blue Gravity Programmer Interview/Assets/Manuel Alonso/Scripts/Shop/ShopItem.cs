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


    public void Setup(Sprite icon, string price)
    {
        _icon.sprite = icon;
        _priceText.text = price;
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
