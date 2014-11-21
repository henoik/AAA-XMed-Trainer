using AXT_Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void FillFromOptions()
        {

        }

        /// <summary>
        /// Checks if at least 'amount' (inclusive) of 'item' is in the inventory.
        /// </summary>
        /// <param name="item">The name of the item to check for.</param>
        /// <param name="amount">Optional. How many of 'item' to look for (inclusive).</param>
        /// <returns>True if this inventory contains at least 'amount' of 'item', false otherwise.</returns>
        public bool Check(IItem item, ushort amount = 1)
        {
            return true;
        }

        /// <summary>
        /// Adds the specified amount of 'item' to this inventory.
        /// </summary>
        /// <param name="item">The name of the item to add.</param>
        /// <param name="amount">How many of the item to add.</param>
        public void Add(IItem item, ushort amount = 1)
        {

        }

        /// <summary>
        /// Removes the specified amount of 'item' to this inventory.
        /// </summary>
        /// <param name="item">The name of the item to remove.</param>
        /// <param name="amount">How many of the item to remove.</param>
        public void Remove(IItem item, ushort amount = 1)
        {

        }

        /// <summary>
        /// Transfers the specified amount of 'item' to the given inventory.
        /// </summary>
        /// <param name="inventory">The inventory to transfer to.</param>
        /// <param name="item">The name of the item to transfer.</param>
        /// <param name="amount">How many of the item to transfer.</param>
        public void Transfer(Inventory inventory, IItem item, ushort amount = 1)
        {

        }
    }
}
