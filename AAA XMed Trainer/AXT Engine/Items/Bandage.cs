
namespace AXT_Engine.Items
{
    public class Bandage : IItem
    {
        public string ItemName
        {
            get { return "Bandage"; }
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
