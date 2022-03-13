namespace GameCsharp.src.Entities
{
    public class Wizard
    { 
        
        public Wizard(string Name, string Level2, int Level, string HeroType, int HP, string Sstrong, int Strong)
        {
          this.Name= Name;
          this.Level= Level;
          this.Level2=Level2;
          this.HeroType= HeroType;
          this.HP=HP;
          this.Sstrong=Sstrong;
          this.Strong=Strong;
        }
        public string Name;
        public int Level;
        public string Level2;
        public string HeroType, Sstrong;
        public int HP, Strong;

        
        public override string ToString(){
            return this.Name + " " + this.Level +this.Level2 + " " + this.HeroType + HP + " "+ this.Sstrong + this.Strong;
        }
        public string Attack(){
            return this.Name + " " + "Lançou a magia";
        }
         public string Attack(int Bonus) { 
         if(Bonus > 600){
            return this.Name + " " + "Lançou uma magia efetiva com bonus de ataque de " + Bonus;}
        else{
            return this.Name + " " + "Lançou uma magia com força fraca de ataque " + Bonus;}
        }   
    }


}