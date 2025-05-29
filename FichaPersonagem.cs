using System;
using static NewIdea.Dado;
//Depois fazer um projeto de stock valuetion
//Inicialmente classe da + 1 em atributo mais condizente 
//Classes : Mago, Ladino,Guerreiro,Bardo
//Raças: Elfo, Humano, Anão, Orc
//atributos : rola 4d6 e descarta o menor

namespace NewIdea
{
    public class FichaPersonagem
    {
        public string NomeJogador { get; set; }
        public string NomePersonagem { get; set; }
        public string Classe { get; set; }
        public string Raca { get; set; }
        public int Nivel { get; private set; }
        public int PVida { get; set; }
        public  int PForca { get; set; }
        public int Inteligencia { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Exp { get; set; }

        bool atributosDefinidos = false;

        public FichaPersonagem(string nomeJogador, string nomePersonagem, string raca, string classe)
        {
           NomeJogador = nomeJogador;
           NomePersonagem = nomePersonagem;
           Raca = raca;
           Classe = classe;
        }

        public void AddAtributosIniciais(int nivel = 1, int exp = 0)
        {
            if (atributosDefinidos == false)
            {
                var (dadosVida,somaVida, menorVida) = DefinirAtributosIniciais();
                var (dadosforca, somaForca, menorForca) = DefinirAtributosIniciais();
                var (dadosInte,somaInte, menorInte) = DefinirAtributosIniciais();
                var (dadosDestreza, somaDestreza, menorDestreza) = DefinirAtributosIniciais();
                var (dadosConst, somaConst, menorConst) = DefinirAtributosIniciais();

                Nivel = nivel;
                PVida = somaVida;
                PForca = somaForca;
                Destreza = somaDestreza;
                Constituicao = somaConst;
                Inteligencia = somaInte;

                AtributrosClasseERaca();
            }
            else Console.WriteLine("Disponivel apenas na criação do personagem !");

        }

        private void AtributrosClasseERaca()
        {
            Inteligencia += Classe == "Mago" ? 1 : 0;
            PForca += Classe == "Guerreiro" ? 1 : 0;
            PVida += Classe == "Bardo" ? 1 : 0;
            if(Classe == "Ladino")
            {
                PForca -= 1;
                Destreza += 1;
            }

            if(Raca == "Elfo")
            {
                Destreza += 2;
                Inteligencia++;
            }
            if (Raca == "Humano")
            {
                PVida++;
                PForca++;
                Destreza++;
                Constituicao++;
                Inteligencia++;
            }
            if (Raca == "Anão")
            {
                Constituicao += 2;
                PForca++;
            }
            if (Raca == "Orc")
            {
                PForca += 2;
                Constituicao++;
            }
        }
        public void LevelUp(int qtdNiveis = 1)
        {
            Nivel += qtdNiveis;
        }




        public override string ToString()
        {
            return $"Nome jogador : {NomeJogador}\n" +
                $"Nome personagem: {NomePersonagem}\n" +
                $"Classe: {Classe}\n" +
                $"Raça: {Raca}\n" +
                $"--------------------------------------------\n" +
                $"Nível: {Nivel} \n" +
                $"Vida: {PVida} \n" +
                $"Força: {PForca}\n" +
                $"Inteligência: {Inteligencia} \n" +
                $"Destreza: {Destreza}  \n" +
                $"Constituição: {Constituicao}  \n" +
                $"Pontos de experiência: {Exp}  \n";
        }
    }
}
