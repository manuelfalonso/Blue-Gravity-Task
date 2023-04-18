using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    [Header("Equipment")]
    [SerializeField]
    private SpriteRenderer _hood = default(SpriteRenderer);
    [SerializeField]
    private SpriteRenderer _shirt = default(SpriteRenderer);
    [SerializeField]
    private SpriteRenderer _pants = default(SpriteRenderer);


    public void EquipHood(Sprite newEquipment)
    {
        Equip(_hood, newEquipment);
    }

    public void EquipShirt(Sprite newEquipment)
    {
        Equip(_shirt, newEquipment);
    }

    public void EquipPants(Sprite newEquipment)
    {
        Equip(_pants, newEquipment);
    }


    private void Equip(SpriteRenderer equipmentSlot, Sprite newEquipment)
    {
        equipmentSlot.sprite = newEquipment;
    }
}
