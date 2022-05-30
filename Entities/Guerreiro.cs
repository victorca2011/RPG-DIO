namespace RPG.Entities
{
    public class Guerreiro : Heroi
    {
        public Guerreiro(string nome, int level) : base(nome, "Guerreiro", level)
        {
            Vida = level * 10;
            Dano = 2;
        }        

         public override string Atacar()
        {
            return $"{Nome} atacou com a espada!";
        }

        public override string Atacar(int bonus)
        {
            if(bonus > 6)
            {
                return $"{Nome} lançou uma magia super efetiva com bonus de {bonus}!";
            }

            return $"{Nome} lançou uma magia fraca com bonus de {bonus}!";            
        }
    }
}