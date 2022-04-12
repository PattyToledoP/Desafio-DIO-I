namespace projeto.SRC;

  public class Wizard : Hero
    {
        
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "  " + "Lancou um feitico de ataque";
        }
        public string Attack (int bonus)
        {
            if (bonus > 6)
            {
                return this.Name + "  " + "Lancou uma magia hiper efetiva com bonus  " + bonus;
            }
            else
            {
                return this.Name + "  " + "Lancou uma magia com forca fraca com bonus  " + bonus;
            }
           
        }
    }
