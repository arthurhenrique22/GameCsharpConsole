namespace GameCsharp.src.Entities
{
    public class Dragon
    {
        public Dragon(string Name, string Level, int Level2, string HeroType, int HP, string Sstrong, int Strong)
        {
            this.Name=Name;
            this.Level=Level;
            this.Level2=Level2;
            this.HeroType=HeroType;
            this.HP=HP;
            this.Sstrong=Sstrong;
            this.Strong=Strong;
        }
        public string Name;
        public string Level;
        public int Level2;
        public string HeroType, Sstrong;
        public int HP, Strong;

        public override string ToString()
        {
            return this.Name + " " + this.Level + Level2 + " " + this.HeroType + " " + this.HP +" "+ this.Sstrong + this.Strong;
        }
        public string Attack(){
            return this.Name+ " " + "Lançou sua chama de fogo";}
        public string Attack(int Bonus){
            if(Bonus > 1800){
                return this.Name + " " + "Lançou sua chama de fogo mais efetiva com bonus de ataque de " + Bonus;}
            else{
                return this.Name + " " + "Lançou sua chama com força mais fraca " + Bonus;}
        }
    }
}