using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT_Engine.Entities
{
    public class Player : AEntity
    {
        public Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }
    }
}
