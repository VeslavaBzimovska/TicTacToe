using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class GamePad: IGamePad
    {
        private readonly int padWidth = 3;
        private readonly int padHeight = 3;

        private UserMark[, ] _gameArea;
        public UserMark[, ] GetGameArea { get; }

        public GamePad()
        {
            Reset();
        }

        public void Reset()
        {
            _gameArea = new UserMark[padWidth, padHeight];

            for (int x = 0; x < padWidth; x++)
            {
                for (int y = 0; y < padHeight; y++)
                {
                    _gameArea[x, y] = UserMark.None;
                }
            }
        }

        public bool MakeTurn(int x, int y, UserMark userMark)
        {
            throw new NotImplementedException();
        }

        public UserMark CheckWin()
        {
            throw new NotImplementedException();
        }

        UserMark[,] IGamePad.GetGameArea()
        {
            throw new NotImplementedException();
        }
    }
}
