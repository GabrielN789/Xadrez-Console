﻿using System.Security.Cryptography.X509Certificates;

namespace TabuleiroConsole
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }

        public void IncremntarQteMovimnto()
        {
            QtdMovimentos++;
        }
        public abstract bool[,] MovimentosPosiveis();       

    }
}
