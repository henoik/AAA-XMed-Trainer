using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT_Engine.Items
{
    public class Bandage : IItem
    {
        public string ItemName
        {
            get { return "Bandage"; }
        }

        public void UseItem(Entities.AEntity target)
        {
            return;
        }
    }
}
