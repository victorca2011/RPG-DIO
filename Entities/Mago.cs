using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Entities
{
    public class Mago : Heroi
    {
        public Mago(string nome, int level) : base(nome, "Mago", level)
        {
            Vida = level * 5;
            Dano = 3;
        }

        public override string Atacar()
        {
            return $"{Nome} lançou uma magia!";
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