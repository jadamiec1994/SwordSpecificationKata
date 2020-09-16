namespace Logic.Models
{
    public class SwordModel
    {
        public string SwordName { get; set; }
        public int SwordYear { get; set; }
        public bool SwordHasBeenUsedInBattle { get; set; }

        public SwordModel(string swordName, int swordYear, bool swordHasBeenUsedInBattle)
        {
            SwordName = swordName;
            SwordYear = swordYear;
            SwordHasBeenUsedInBattle = swordHasBeenUsedInBattle;
        }
    }
}