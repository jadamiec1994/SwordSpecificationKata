using Logic.Models;

namespace Logic.Objects
{
    public class SwordsObject
    {
        public SwordModel SteelSword()
        {
            return new SwordModel("Steel Sword", 1750, false);
        }

        public SwordModel BronzeSword()
        {
            return new SwordModel("Bronze Sword", 950, true);
        }

        public SwordModel DragonSword()
        {
            return new SwordModel("Dragon Sword", 1234, true);
        }
    }
}
