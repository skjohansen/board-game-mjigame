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

        // Constructor
        public GameBoard()
        {
            Fields = new List<string>();

            // Add 9 fields with the string "W.png" (White background)
            for (int i = 0; i < 9; i++)
            {
                Fields.Add("W.png");
            }
        }
    }
}
