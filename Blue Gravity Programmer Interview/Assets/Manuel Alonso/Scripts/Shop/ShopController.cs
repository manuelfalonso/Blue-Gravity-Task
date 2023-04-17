using UnityEngine;
using UnityEngine.Events;

public class ShopController : MonoBehaviour
{
    [SerializeField]
    private ShopItem _shopItemPrefab = default(ShopItem);
    [SerializeField]
    private Transform _shopItemsParent = default(Transform);

    [Header("Data")]
    [SerializeField]
    private ItemShopStock _shopStock = default;

    [Header("Events")]
    public UnityEvent<ItemShop> OnItemBought = new UnityEvent<ItemShop>();

    void Start()
    {
        LoadShop(_shopStock);
    }


    public void LoadShop(ItemShopStock _shopStock)
    {
        foreach (var item in _shopStock.Stock)
        {
            var go = Instantiate(_shopItemPrefab, _shopItemsParent);
            go.GetComponent<ShopItem>().OnBuyItem.AddListener(Buy);
            go.Setup(item);
        }
    }

    public void Buy(ItemShop data)
    {
        OnItemBought?.Invoke(data);
    }
}
