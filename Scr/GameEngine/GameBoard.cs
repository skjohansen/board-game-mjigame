using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class GameBoard
    {
        public List<string> Fields { get; set; }

        public GameBoard()
        {
            Fields = new List<string>();

            for (int i = 0; i < 9; i++)
            {
                Fields.Add("empty.png");
            }
        }
    }
}
