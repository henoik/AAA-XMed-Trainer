
namespace AXT_Engine.Items
{
    public class SelfCPR : IItem
    {
        public string ItemName
        {
            get { return "Give CPR"; }
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
