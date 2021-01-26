using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Computer : Cpu
    {
        protected Cpu cpu;
        protected Graphics graphics;
        protected string board;

        public Computer(int cores, string model, string graphicsModle, string board) : base(cores, model)
        {
            this.graphics = new Graphics(graphicsModle);
            this.board = board;
        }
    }
}
