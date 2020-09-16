using Logic.Interfaces;
using Logic.Models;

namespace Logic.Specifications
{
    public class SwordYearSpecification : ISwordSpecification
    {
        private readonly int _swordYear;

        public SwordYearSpecification(int swordYear)
        {
            _swordYear = swordYear;
        }

        public bool IsSatisfiedBy(SwordModel swordModel)
        {
            return swordModel.SwordYear > _swordYear;
        }
    }
}