namespace projeto.SRC
{
    public class Opponent : Hero
    {
        public Opponent(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "  " + "Lancou um golpe de ataque";
        }
        public string Attack (int bonus)
        {
            if (bonus > 3)
            {
                return this.Name + "  " + "Lancou um ataque efetivo com bonus  " + bonus;
            }
            else
            {
                return this.Name + "  " + "Lancou um ataque com forca fraca com bonus  " + bonus;
            }
           
        }
    }
}