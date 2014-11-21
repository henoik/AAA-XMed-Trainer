using AXT_Engine.Stat_Enums;

namespace AXT_Engine.Entities
{
    // Set default values used by XMedSys/Arma.
    public abstract class AEntity
    {
        #region Constants
        public readonly ushort STARTING_BLOOD_LEVEL = 6000;
        public readonly ushort STARTING_HEALTH = 0;
        public readonly ushort STARTING_LIFE_TIME_TIMER = 600;
        #endregion Constants

        public ushort BloodLevel { get; set; }
        public BleedAmount BleedLevel { get; set; }

        public ushort Health { get; set; }

        public ushort LifeTimeTimer { get; set; }

        public bool Dead { get; set; }

        public AEntity()
        {
            BloodLevel = STARTING_BLOOD_LEVEL;
            BleedLevel = BleedAmount.None;

            Health = STARTING_HEALTH;

            LifeTimeTimer = STARTING_LIFE_TIME_TIMER;

            Dead = false;
        }

        /// <summary>
        /// Checks if this Entity should be knocked out due to blood loss.
        /// </summary>
        /// <returns>True if this unit should be knocked out, false otherwise.</returns>
        public bool CheckLowBloodKnockOut()
        {
            if (BloodLevel < (STARTING_BLOOD_LEVEL * 0.2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
