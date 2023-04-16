using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item Stock", menuName = "Data/Shop Item Stock", order = 51)]
public class ItemShopStock : ScriptableObject
{
    public List<ItemShop> Stock = new List<ItemShop>();
}
