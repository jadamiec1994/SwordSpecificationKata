using Logic.Models;

namespace Logic.Interfaces
{
    public interface ISwordSpecification
    {
        bool IsSatisfiedBy(SwordModel swordModel);
    }
}
