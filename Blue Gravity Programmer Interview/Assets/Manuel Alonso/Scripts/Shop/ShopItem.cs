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
    public UnityEvent<ItemShop> OnBuyItem = new UnityEvent<ItemShop>();


    private bool _isInitialized = false;
    private ItemShop _data = default(ItemShop);


    public void Setup(ItemShop data)
    {
        _icon.sprite = data.Icon;
        _priceText.text = data.BuyPrice.ToString();
        _data = data;
        _isInitialized = true;
    }

    // Called fron Unity Event
    public void Buy()
    {
        Debug.Log($"This item was bought");

        if (!_isInitialized) return;

        // Check if the player has enough currency and reduce its amount
        if (!PlayerCurrencyManager.Instance.ReduceCoins((int)_data.BuyPrice))
            return;

        _isInitialized = false;
        gameObject.SetActive(false);

        OnBuyItem?.Invoke(_data);

        Reset();
    }


    private void Reset()
    {
        _icon = null;
        _priceText.text = string.Empty;
        _data = null;
    }
}
