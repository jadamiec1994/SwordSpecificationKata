using System;
using System.Linq;
using Logic.Models;
using Logic.Objects;
using Logic.Specifications;

namespace SwordSpecificationKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var SwordObject = new SwordsObject();
            var swords = new SwordModel[] { SwordObject.SteelSword(),
                SwordObject.BronzeSword(),
                SwordObject.DragonSword() };

            Console.WriteLine("Welcome to the Sword Shop");
            Console.WriteLine("Please specify the minimum year the sword was made:");

            var swordMinimumYear = Console.ReadLine();
            var validSwords = GetSwords.GetSwordBy(new SwordYearSpecification(Int32.Parse(swordMinimumYear)),
                swords);

            Console.WriteLine("Please specify if you want a sword that was used in battle");
            var SwordHasBeenUsedInBattle = Console.ReadLine();

            var validBattleSwords = GetSwords.GetSwordBy
                (new SwordHasBeenUsedInBattleSpecification(bool.Parse(SwordHasBeenUsedInBattle)),
                swords);

            var CommonSwords = validSwords.Intersect(validBattleSwords);

            foreach (var validSword in CommonSwords)
            {
                Console.WriteLine(validSword.SwordName);
            }
        }
    }
}
