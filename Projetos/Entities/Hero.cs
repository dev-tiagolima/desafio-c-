namespace Projetos.Entities
{
    public class Hero
    {
        public Hero(){

        }
        public Hero(string Name,  string HeroType, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Name;

        public string HeroType;

        public int Level;

        public int HP;

        public int MP;

        public override string ToString()
        {
            return this.Name + " " + this.HeroType + " / Level: " + this.Level + "\n/ Vida: " + this.HP + " / Mana: " + this.MP;
        }
        
        public virtual string Attack(){
            return this.Name + " Ataque";
        }
    }
}