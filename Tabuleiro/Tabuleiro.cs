﻿namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas { get; set; }

        public Tabuleiro()
        {
        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }
    }
}
