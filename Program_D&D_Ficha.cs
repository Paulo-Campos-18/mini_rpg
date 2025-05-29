// Maybe a prg systam for create caracter 
//Depois fazer um projeto de stock valuetion
using NewIdea;
using static NewIdea.Dado;
using System;
using System.Globalization;

namespace Rpg
{
    class Rpg
    {
        static void Main()
        {
            FichaPersonagem Pessoa1 = new("Paulo","Algust","Humano","Mago");
            Pessoa1.AddAtributosIniciais();
            Console.WriteLine(Pessoa1);

            var resultado = DefinirAtributosIniciais();
            Console.WriteLine($"Dados rolados: {string.Join(", ", resultado.dados)}");
            Console.WriteLine($"O Menor dados será descartado: {resultado.menor} descartado");
            Console.WriteLine($"Vida total: {resultado.soma}");

        }

    }


}


