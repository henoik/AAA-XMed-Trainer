
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
            target.BloodLevel += (ushort)(target.STARTING_BLOOD_LEVEL * 0.25);

            if (target.BloodLevel > target.STARTING_BLOOD_LEVEL)
            {
                target.BloodLevel = target.STARTING_BLOOD_LEVEL;
            }
        }
    }
}
