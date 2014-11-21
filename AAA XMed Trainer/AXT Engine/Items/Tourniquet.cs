
namespace AXT_Engine.Items
{
    public class Tourniquet : IItem
    {
        public string ItemName
        {
            get { return "Tourniquet"; }
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
