using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [SerializeField]
    private Image _itemIcon = default;


    public void Setup(Sprite itemSprite)
    {
        _itemIcon.sprite = itemSprite;
    }
}
