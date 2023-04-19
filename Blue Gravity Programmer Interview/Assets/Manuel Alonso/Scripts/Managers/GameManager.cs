using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool IsShopOpen { get; private set; }
    public bool IsInventoryOpen { get; private set; }


    private void Start()
    {
        Tapestry.TapestryEventRegistry.OnShopInteraction.SubscribeMethod(
            (isOpen) =>
            {
                IsShopOpen = isOpen;
                if (IsInventoryOpen)
                    IsInventoryOpen = !isOpen;
            }, false);
        Tapestry.TapestryEventRegistry.OnInventoryInteraction.SubscribeMethod(
            (isOpen) =>
            {
                IsInventoryOpen = isOpen;
                if (IsShopOpen)
                    IsShopOpen = !isOpen;
            }, false);
    }
}
