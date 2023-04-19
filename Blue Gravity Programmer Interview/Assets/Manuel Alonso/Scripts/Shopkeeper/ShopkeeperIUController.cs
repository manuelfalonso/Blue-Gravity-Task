using UnityEngine;

public class ShopkeeperIUController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    private GameObject _shopUI = default(GameObject);
    [SerializeField]
    private GameObject _inventoryUI = default(GameObject);


    public void ToggleOpenShop()
    {
        if (_shopUI.activeSelf && !_inventoryUI.activeSelf)
        {
            _inventoryUI.SetActive(true);
        }
        else if (_shopUI.activeSelf && _inventoryUI.activeSelf)
        {
            _shopUI.SetActive(false);
            _inventoryUI.SetActive(false);
        }
        else
        {
            _shopUI.SetActive(true);
            _inventoryUI.SetActive(true);
        }

        Tapestry.TapestryEventRegistry.OnShopInteraction?.Invoke(_shopUI.activeSelf);
    }
}
