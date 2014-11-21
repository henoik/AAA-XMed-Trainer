
namespace AXT_Engine.Items
{
    public class Bloodbag : IItem
    {
        public string ItemName
        {
            get { return "Bloodbag"; }
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
