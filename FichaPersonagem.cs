using System;
//Depois fazer um projeto de stock valuetion
namespace NewIdea
{
    public class FichaPersonagem
    {
         string nomePersonagem,nomeJogador,classe,raca;
         int nivel, pVida, pForça, intelignecia,pExperiencia;

        void CriarPersonagem()
        {
            Console.WriteLine("Digite o nome do personagem");
            nomePersonagem = Console.ReadLine();
            Console.WriteLine("Digite o nome do Jogador");
            nomeJogador = Console.ReadLine();
            Console.WriteLine("Digite o classe do seu personagem");
            classe = Console.ReadLine();
            Console.WriteLine("Digite o raça do seu personagem");
            raca = Console.ReadLine();

 
        }



    }
}
