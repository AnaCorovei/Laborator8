using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8
{
    class Incarcatura
    {
        public int Cantitate { get; set; }
        public TipMarfa TipMarfa { get; private set; }

        public Incarcatura(TipMarfa tipMarfa)
        {
            this.TipMarfa = tipMarfa;
        }
    }
}