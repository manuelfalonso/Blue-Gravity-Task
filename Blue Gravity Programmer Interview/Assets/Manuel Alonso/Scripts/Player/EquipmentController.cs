using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    [Header("Equipment")]
    [SerializeField]
    private ItemShop _hoodItem = default(ItemShop);
    [SerializeField]
    private ItemShop _shirtItem = default(ItemShop);
    [SerializeField]
    private ItemShop _pantsItem = default(ItemShop);

    [Header("Sprites")]
    [SerializeField]
    private SpriteRenderer _hoodSprite = default(SpriteRenderer);
    [SerializeField]
    private SpriteRenderer _shirtSprite = default(SpriteRenderer);
    [SerializeField]
    private SpriteRenderer _pantsSprite = default(SpriteRenderer);


    private void Start()
    {
        EquipmentSetup();
        Tapestry.TapestryEventRegistry.OnItemEquiped.SubscribeMethod(
            SwapItemWithInventory, false);
    }


    // Called from Unity Event
    public void EquipItemShop(ItemShop data)
    {
        switch (data.type)
        {
            case ItemShop.Type.Hood:
                EquipHood(data.Icon);
                break;
            case ItemShop.Type.Shirt:
                EquipShirt(data.Icon);
                break;
            case ItemShop.Type.Pants:
                EquipPants(data.Icon);
                break;
            default:
                Debug.LogError("Incorrect ItemShop type");
                break;
        }
    }


    private void EquipHood(Sprite newEquipment)
    {
        Equip(_hoodSprite, newEquipment);
    }

    private void EquipShirt(Sprite newEquipment)
    {
        Equip(_shirtSprite, newEquipment);
    }

    private void EquipPants(Sprite newEquipment)
    {
        Equip(_pantsSprite, newEquipment);
    }

    private void Equip(SpriteRenderer equipmentSlot, Sprite newEquipment)
    {
        equipmentSlot.sprite = newEquipment;
    }

    private void EquipmentSetup()
    {
        EquipHood(_hoodItem.Icon);
        EquipShirt(_shirtItem.Icon);
        EquipPants(_pantsItem.Icon);
    }

    private void SwapItemWithInventory(ItemShop itemData, InventoryController inventory)
    {
        // Swap new item with the equipped
        switch (itemData.type)
        {
            case ItemShop.Type.Hood:
                inventory.AddItemToInventory(_hoodItem);
                _hoodItem = itemData;
                break;
            case ItemShop.Type.Shirt:
                inventory.AddItemToInventory(_shirtItem);
                _shirtItem = itemData;
                break;
            case ItemShop.Type.Pants:
                inventory.AddItemToInventory(_pantsItem);
                _pantsItem = itemData;
                break;
            default:
                Debug.LogError("Incorrect ItemShop type");
                break;
        }

        // Finally equip the item
        EquipItemShop(itemData);
    }
}
