
namespace AXT_Engine.Items
{
    public interface IItem
    {
        /// <summary>
        /// Set the external name of this item.
        /// </summary>
        string ItemName { get; }

        /// <summary>
        /// Set how long this item takes to use, before the effect is applied, in milliseconds.
        /// </summary>
        ushort ItemUseTime { get; }
        
        /// <summary>
        /// Uses this item on the given Dummy target.
        /// </summary>
        /// <param name="target">The entity target to use this item on.</param>
        void UseItem(Entities.AEntity target);
    }
}
