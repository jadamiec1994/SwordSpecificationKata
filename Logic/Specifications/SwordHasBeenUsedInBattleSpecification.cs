using Logic.Interfaces;
using Logic.Models;

namespace Logic.Specifications
{
    public class SwordHasBeenUsedInBattleSpecification : ISwordSpecification
    {
        private readonly bool _swordHasBeenUsedInBattle;

        public SwordHasBeenUsedInBattleSpecification(bool swordHasBeenUsedInBattle)
        {
            _swordHasBeenUsedInBattle = swordHasBeenUsedInBattle;
        }

        public bool IsSatisfiedBy(SwordModel swordModel)
        {
            return swordModel.SwordHasBeenUsedInBattle.Equals(_swordHasBeenUsedInBattle);
        }
    }
}