using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item", menuName = "Data/Shop Item", order = 51)]
public class ItemShop : Item
{
    public Sprite Icon = default(Sprite);
    public float BuyPrice = default;
    public float SellPrice = default(float);
    public int Stock = default(int);
}
