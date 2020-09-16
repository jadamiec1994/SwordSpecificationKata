using System.Collections.Generic;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Objects
{
    public class GetSwords
    {
        public static List<SwordModel> GetSwordBy(ISwordSpecification swordSpecification, SwordModel[] swordModels)
        {
            var RelevantSwords = new List<SwordModel>();

            foreach (SwordModel swordModel in swordModels)
            {
                if (swordSpecification.IsSatisfiedBy(swordModel))
                {
                    RelevantSwords.Add(swordModel);
                }
            }

            return RelevantSwords;
        }
    }
}
