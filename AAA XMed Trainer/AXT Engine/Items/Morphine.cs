
namespace AXT_Engine.Items
{
    public class Morphine : IItem
    {
        public string ItemName
        {
            get { return "Morphine"; }
        }

        public ushort ItemUseTime
        {
            get { return 8; }
        }

        public void UseItem(Entities.AEntity target)
        {
            return;
        }
    }
}
