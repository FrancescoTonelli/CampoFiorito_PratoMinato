using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PratoFiorito
{
    public class Campo
    {
        private int[,] _griglia;

        public Campo()
        {
            Griglia = new int[8, 8];
            Riempi();
        }

        public int[,] Griglia
        {
            get
            {
                return _griglia;
            }
            set
            {
                _griglia = Griglia;
            }
        }

        public void Riempi()
        {
            int i = 10;

            while (i != 0)
            {

            }
        }
    }
}