namespace GameCsharp.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name,string Level2, int Level, string HeroType, int HP, string Sstrong, int Strong)
        {
          this.Name= Name;
          this.Level= Level;
          this.Level2= Level2;
          this.HeroType= HeroType;
          this.HP=HP;
          this.Sstrong=Sstrong;
          this.Strong=Strong;
        }
        public  string Name;
        public  int Level;
        public string Level2;
        public string HeroType, Sstrong;
        public int HP, Strong;
        
        public override string ToString()
        {
            return this.Name + " " + this.Level + this.Level2 + " " + this.HeroType + this.HP +" "+ this.Sstrong + this.Strong;
        }
        public virtual string Attack(){
            return this.Name + " " + "Atacou com a sua espada";

        }
       
    }
}