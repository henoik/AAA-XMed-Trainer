
namespace AXT_Engine.Items
{
    public class Defibrillator : IItem
    {
        public string ItemName
        {
            get { return "Defibrillator"; }
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
