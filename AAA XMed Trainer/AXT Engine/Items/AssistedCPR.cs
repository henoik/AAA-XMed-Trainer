
namespace AXT_Engine.Items
{
    public class AssistedCPR : IItem
    {
        public string ItemName
        {
            get { return "Request CPR Help"; }
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
