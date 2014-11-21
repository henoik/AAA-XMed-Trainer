using AXT_Engine.Items;
using System.Collections.Generic;

namespace AXT_Engine
{
    /// <summary>
    /// A simple Dictonary wraper for managing a player's inventory.
    /// </summary>
    public class Inventory
    {
        private Dictionary<IItem, ushort> inventory;

        public Inventory()
        {
            inventory = new Dictionary<IItem, ushort>();
        }

        /// <summary>
        /// Fills this inventory with the inventory setup defined in the OptionsForm.
        /// </summary>
        /// <returns>True if the load was successful, false otherwise.</returns>
        public bool FillFromOptions()
        {
            return true;
        }

        /// <summary>
        /// Checks if at least 'amount' (inclusive) of 'item' is in the inventory.
        /// </summary>
        /// <param name="item">The name of the item to check for.</param>
        /// <param name="amount">Optional. How many of 'item' to look for (inclusive).</param>
        /// <returns>True if this inventory contains at least 'amount' of 'item' (inclusive), false otherwise.</returns>
        public bool Check(IItem item, ushort amount = 1)
        {
            if (item == null)
            {
                return false;
            }

            ushort amountHeldInInventory;
            if(inventory.TryGetValue(item, out amountHeldInInventory))
            {
                if (amountHeldInInventory >= amount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the specified amount of 'item' to this inventory.
        /// </summary>
        /// <param name="item">The name of the item to add.</param>
        /// <param name="amount">How many of the item to add.</param>
        /// <returns>True if the add was successful, false otherwise.</returns>
        public bool Add(IItem item, ushort amount = 1)
        {
            if (item == null || amount == 0)
            {
                return false;
            }

            if (inventory.ContainsKey(item))
            {
                ushort amountHeldInInventory;
                if (inventory.TryGetValue(item, out amountHeldInInventory))
                {
                    inventory.Remove(item);

                    amountHeldInInventory += amount;
                    inventory.Add(item, amountHeldInInventory);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                inventory.Add(item, amount);
                return true;
            }
        }

        /// <summary>
        /// Removes the specified amount of 'item' to this inventory.
        /// </summary>
        /// <param name="item">The name of the item to remove.</param>
        /// <param name="amount">How many of the item to remove.</param>
        /// <returns>True if the remove was successful, false otherwise.</returns>
        public bool Remove(IItem item, ushort amount = 1)
        {
            if (item == null || amount == 0)
            {
                return false;
            }

            if (inventory.ContainsKey(item))
            {
                ushort amountHeldInInventory;
                if (inventory.TryGetValue(item, out amountHeldInInventory))
                {
                    inventory.Remove(item);

                    int newAmount = amountHeldInInventory - amount;
                    if (newAmount > 0)
                    {
                        inventory.Add(item, (ushort)newAmount);
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Transfers the specified amount of 'item' to the given inventory.
        /// </summary>
        /// <param name="inventory">The inventory to transfer to.</param>
        /// <param name="item">The name of the item to transfer.</param>
        /// <param name="amount">How many of the item to transfer.</param>
        /// <returns>True if the transfer was successful, false otherwise.</returns>
        public bool Transfer(Inventory inventory, IItem item, ushort amount = 1)
        {
            if (inventory == null || item == null || amount == 0)
            {
                return false;
            }

            if (Check(item, amount))
            {
                if (Remove(item, amount))
                {
                    if (inventory.Add(item, amount))
                    {
                        return true;
                    }
                    else
                    {
                        Add(item, amount);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
