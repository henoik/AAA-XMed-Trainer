
namespace AXT_Engine.Items
{
    public class Epinephrine : IItem
    {
        public string ItemName
        {
            get { return "Epinephrine"; }
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
