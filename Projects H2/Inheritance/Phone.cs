using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Phone : Computer
    {
        protected decimal size;
        protected Computer computer;

        public Phone(decimal size, int cores, string model, string graphicsModel, string board) : base(cores, model, graphicsModel, board)
        {
            this.size = size;
        }
    }
}
