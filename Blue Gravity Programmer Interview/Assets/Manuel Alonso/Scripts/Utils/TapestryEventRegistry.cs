using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script was imported
namespace Tapestry
{
    public class TapestryEventRegistry
    {

        #region Example
        /// <summary>
        /// Reports when Map objects are instantiated
        /// </summary>
        public static TapestryEvent<GameObject> OnObjectSpawnedExample;
        #endregion

        static TapestryEventRegistry()
        {
            CreateTapestryEvents();
        }

        private static void CreateTapestryEvents()
        {

            #region Example
            OnObjectSpawnedExample = new TapestryEvent<GameObject>();
            #endregion
        }

        public static void OnDestroy()
        {
            // Creates new events to clear the old ones
            CreateTapestryEvents();
        }
    }
}