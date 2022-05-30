using System;
using RPG.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi heroi = new Guerreiro("Giorno", 1);
            Heroi vilao = new Mago("Diavolo", 1);
            Random dado = new Random();

            Console.WriteLine($"Você é um heroi guerreiro chamado {heroi.Nome}.");
            Console.WriteLine($"Está prestes a enfrentar um vilão mago chamado {vilao.Nome}");
            while (heroi.EstaVivo && vilao.EstaVivo)
            {
                Console.WriteLine(heroi);
                Console.WriteLine(vilao);
                Console.WriteLine("Deseja atacar ou defender?");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender");
                var opcao = Console.ReadLine();
                var opcaoVilao = dado.Next(1, 3);

                if (opcao == "1")
                {
                    var resultado = dado.Next(1, 21);
                    if (resultado > 5 && opcaoVilao == 1)
                    {
                        heroi.Atacar();
                        vilao.ReceberDano(heroi.Dano);
                    }
                    else
                    {
                        Console.WriteLine($"{vilao.Nome} defendeu do seu ataque!");
                    }
                }
                
                if (opcaoVilao == 1)
                {
                    Console.WriteLine($"Agora {vilao.Nome} irá atacar:");
                    if (opcao != "1")
                    {
                        Console.WriteLine("Você defendeu o ataque com sucesso!");
                    }
                    else
                    {
                        var resultado = dado.Next(1, 21);
                        if (resultado > 12)
                        {
                            vilao.Atacar();
                            heroi.ReceberDano(vilao.Dano);
                        }
                        else
                        {
                            Console.WriteLine($"Voce desviou do ataque de {vilao.Nome}!");
                        }
                    }
                }
            }

            if (heroi.EstaVivo)
            {
                Console.WriteLine("Parabéns! Você ganhou a batalha!");
            }
            else
            {
                Console.WriteLine("É uma pena! Você perdeu a batalha!");
            }

        }
    }
}
