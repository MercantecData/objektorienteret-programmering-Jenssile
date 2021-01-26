using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Laptop : Computer
    {
        protected decimal width;
        protected Computer computer;

        public Laptop(decimal width, int cores, string model, string graphicsModel, string board) : base(cores, model, graphicsModel, board)
        {
            this.width = width;
        }
    }
}
