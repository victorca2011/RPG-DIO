using System;

namespace RPG.Entities
{
    public abstract class Heroi
    {
        public string Nome { get; set; }
        public string Tipo { get; protected set; }
        public int Level { get; set; }
        public int Dano { get; protected set; }
        public int Vida { get; set; }
        public bool EstaVivo { get { return Vida > 0; } }

        public Heroi(string nome, string tipo, int level)
        {
            Nome = nome;
            Tipo = tipo;
            Level = level;
        }

        public override string ToString()
        {
            return $"{Nome} - {Vida}";
        }

        public abstract string Atacar();
        public abstract string Atacar(int bonus);
        public void ReceberDano(int dano)
        {            
            Vida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano!");
        }
    }
}