
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
