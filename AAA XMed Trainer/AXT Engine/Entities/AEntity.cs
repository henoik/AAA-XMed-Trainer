using AXT_Engine.Stat_Enums;

namespace AXT_Engine.Entities
{
    public abstract class AEntity
    {
        public uint BloodLevel { get; set; }
        public BleedAmount BleedLevel { get; set; }

        public uint Health { get; set; }

        public bool Dead { get; set; }
    }
}
