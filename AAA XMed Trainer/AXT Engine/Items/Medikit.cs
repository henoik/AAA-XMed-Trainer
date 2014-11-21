
namespace AXT_Engine.Items
{
    public class Medikit : IItem
    {
        public string ItemName
        {
            get { return "Medikit"; }
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
