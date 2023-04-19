using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was imported
namespace Tapestry
{
    public class TapestryEventRegistry
    {

        #region GameManager
        /// <summary>
        /// Reports when the Shop was open or closed
        /// </summary>
        public static TapestryEvent<bool> OnShopInteraction;
        /// <summary>
        /// Reports when the Inventory was open or closed
        /// </summary>
        public static TapestryEvent<bool> OnInventoryInteraction;
        #endregion

        #region Inventory
        /// <summary>
        /// Reports when an item is equiped succesull
        /// </summary>
        public static TapestryEvent<ItemShop, InventoryController> OnItemEquiped;
        #endregion

        static TapestryEventRegistry()
        {
            CreateTapestryEvents();
        }

        private static void CreateTapestryEvents()
        {
            #region GameManager
            OnShopInteraction = new TapestryEvent<bool>();
            OnInventoryInteraction = new TapestryEvent<bool>();
            #endregion

            #region Inventory
            OnItemEquiped = new TapestryEvent<ItemShop, InventoryController>();
            #endregion
        }

        public static void OnDestroy()
        {
            // Creates new events to clear the old ones
            CreateTapestryEvents();
        }
    }
}