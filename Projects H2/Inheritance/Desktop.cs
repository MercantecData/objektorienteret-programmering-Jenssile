using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Desktop : Computer
    {
        protected int numberMonitors;
        protected Computer computer;

        public Desktop(int numberMonitors, int cores, string model, string graphicsModel, string board) : base(cores, model, graphicsModel, board)
        {
            this.numberMonitors = numberMonitors;
        }
    }
}
