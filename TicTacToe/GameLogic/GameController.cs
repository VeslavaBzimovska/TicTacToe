using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class GameController
    {
        private IGamePad _gamePad;
        public GameController()
        {
            _gamePad = new GamePad();
        }
    }
}
