namespace Projetos.Entities
{
  public class Wizard : Hero
  
  {
       public Wizard(string Name,  string HeroType, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack(){
            return this.Name + " Used Magic Spell";
  }
}}