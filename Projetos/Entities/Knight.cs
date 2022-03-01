namespace Projetos.Entities
{
  public class Knight : Hero
  
  {
       public Knight(string Name,  string HeroType, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack(){
            return this.Name + " Fatiou os cara";
        }}