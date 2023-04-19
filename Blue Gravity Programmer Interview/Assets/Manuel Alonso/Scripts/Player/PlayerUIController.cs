using UnityEngine;

public class PlayerUIController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    private GameObject _shopUI = default(GameObject);
    [SerializeField]
    private GameObject _inventoryUI = default(GameObject);


    public void ToggleOpenInventory()
    {
        if (_shopUI.activeSelf && !_inventoryUI.activeSelf)
        {
            _shopUI.SetActive(false);
            _inventoryUI.SetActive(true);
        }
        else if (_shopUI.activeSelf && _inventoryUI.activeSelf)
        {
            _shopUI.SetActive(false);
        }
        else if (!_inventoryUI.activeSelf)
        {
            _inventoryUI.SetActive(true);
        }
        else
        {
            _inventoryUI.SetActive(false);
        }

        Tapestry.TapestryEventRegistry.OnInventoryInteraction?.Invoke(_inventoryUI.activeSelf);
    }
}
