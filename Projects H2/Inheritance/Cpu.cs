using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Cpu
    {
        protected int cores;
        protected string model;

        public Cpu(int cores, string model)
        {
            this.cores = cores;
            this.model = model;
        }
    }
}
