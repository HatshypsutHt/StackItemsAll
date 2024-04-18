using System.Collections.Generic;
using Oxide.Core;
using Oxide.Core.Plugins;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("StackItemsAll", "Hatshypsut", "1.0.0")]
    [Description("Increases the maximum stack size of all items in the game by 10 times")]

    public class StackItemsAll : RustPlugin
    {

        private void OnServerInitialized()
        {
            IncreaseStackSizes();
        }

        private void IncreaseStackSizes()
        {
            foreach (ItemDefinition item in ItemManager.GetItemDefinitions())
            {
                if (item != null)
                {
                    item.stackable = 10000; // We set the maximum stack size
                }
            }

            Puts("Stack sizes increased to 10000 for all items in the game.");
        }
    }
}
