using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    private bool _isShopOpen = false;
    [SerializeField]
    private bool _isInventoryOpen = false;
}
