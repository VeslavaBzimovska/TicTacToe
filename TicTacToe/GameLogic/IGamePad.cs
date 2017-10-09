using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public interface IGamePad
    {
        void Reset();
        bool MakeTurn(int x, int y, UserMark userMark);
        UserMark CheckWin();
        UserMark[,] GetGameArea();
    }
}
