using System;
using System.Globalization;

//Dado aleatório, e mostra se foi bom ou não, função para caso se falhe, uma verificação que recebe a dificuldade.
//Colocar a mecánica de dado da morte, 3 falhas mata.

namespace NewIdea
{
    public static class Dado
    {
        static string dificuldade;

        private readonly static Random _random = new();
        public static int D6()
        {
            return _random.Next(1,7);
        }
        public static int D20()
        {
            return _random.Next(1, 21);
        }
        public static int D100()
        {
            return _random.Next(1,101);
        }
        public static int DadoEspecial(int n1,int n2)
        {
            return _random.Next(n1, n2);
        }

    }
}
