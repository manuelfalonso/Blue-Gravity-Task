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
        if (!LoadShop(_shopStock))
            Debug.Log($"Error initializing Shop");
    }


    public bool LoadShop(ItemShopStock _shopStock)
    {
        bool isSucces = false;

        foreach (var item in _shopStock.Stock)
        {
            var go = Instantiate(_shopItemPrefab, _shopItemsParent);
            go.Setup(item);
        }

        return isSucces;
    }

    public void Buy()
    {

    }

    public void Sell()
    {

    }
}
