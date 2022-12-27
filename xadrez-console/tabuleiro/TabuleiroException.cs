using System;
using tabuleiro.Enums;
namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
