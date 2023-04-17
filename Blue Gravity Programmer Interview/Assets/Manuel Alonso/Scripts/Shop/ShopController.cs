using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField]
    private ShopItem _shopItemPrefab = default(ShopItem);
    [SerializeField]
    private Transform _shopItemsParent = default(Transform);

    [Header("Data")]
    [SerializeField]
    private ItemShopStock _shopStock = default;


    void Start()
    {
        LoadShop(_shopStock);
    }


    public void LoadShop(ItemShopStock _shopStock)
    {
        foreach (var item in _shopStock.Stock)
        {
            var go = Instantiate(_shopItemPrefab, _shopItemsParent);
            go.Setup(item);
        }
    }

    public void Buy(ItemShop data)
    {

    }
}
