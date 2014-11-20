using AXT_Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT_Engine.Items
{
    public interface IItem
    {
        /// <summary>
        /// Set the external name of this item.
        /// </summary>
        string ItemName { get; }
        
        /// <summary>
        /// Uses this item on the given Dummy target.
        /// </summary>
        /// <param name="target">The dummy target to use this item on.</param>
        void UseItem(Dummy target);
    }
}
