using System;
using System.Globalization;

//Dado aleatório, e mostra se foi bom ou não, função para caso se falhe, uma verificação que recebe a dificuldade.
//Colocar a mecánica de dado da morte, 3 falhas mata.

namespace NewIdea
{
    public static class Dado
    {
        private readonly static Random _random = new();
        public static int D6()
        {
            return _random.Next(1, 7);
        }
        public static int D20()
        {
            return _random.Next(1, 21);
        }
        public static int D100()
        {
            return _random.Next(1, 101);
        }
        public static int DadoEspecial(int n1, int n2)
        {
            return _random.Next(n1, n2 + 1);
        }
        public static string ShowResultDado(int valorDado)
        {
            return $"Valor do dado = {valorDado}\n";
        }
        public static string TesteD20(int dificuldade)
        {
            int dadoResult = D20();
            ShowResultDado(dadoResult);

            if (dadoResult == 1)
            {
                return "Falha crítica!";
            }
            else if (dadoResult < dificuldade)
            {
                return "Falha";
            }
            else if (dadoResult == 20)
            {
                return "20 estrondoso!";
            }
            else return "Sucesso";

        }
        
        public static string RolagemMorte()
        {//Após criar a ficha do personagem, inserir aq um contador de sucessos e falhas,por enquato usar variáveis locais
         //Decidir dps quem cuida da contagem e morte, aqui ou a classe de ficha,provavelmente a ficha   
            int sucessos = 0;
            int falhas = 0;

            string testResult = TesteD20(10);
            if (testResult == "Falha crítica!")
            {
                falhas += 2;
                Console.WriteLine("Foram somadas 2 falhas no contador");
               return $"Falhas: {falhas}";
            } else if (testResult == "Falha")
            {
                falhas++;
                return $"Falhas: {falhas}";
            } else if (testResult == "20 estrondoso!")
            {
                sucessos += 3;
                return"Você se levanta";
            } else
            {
                sucessos++;
                return $"Sucessos: {sucessos}";
            }
        }
    }
}
