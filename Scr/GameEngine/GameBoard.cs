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
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
            Fields.Add("W.png");
        }
    }
}
