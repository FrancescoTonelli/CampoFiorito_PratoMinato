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

        Random r = new Random();

        public void Riempi() //casella = 0 -> niente, = n -> bombe nei paraggi, = -1 -> bomba
        {
            Griglia = new int[8, 8];
            int i = 10;

            for(int n = 0; n < Griglia.GetLength(0); n++)
            {
                for (int m = 0; m < Griglia.GetLength(1); m++)
                {
                    Griglia[n, m] = 0;
                }
            }

            while (i != 0)
            {
                int x = r.Next(0, 8);
                int y = r.Next(0, 8);

                if(Griglia[x,y] != -1)
                {
                    Griglia[x, y] = -1;
                    i--;
                }
            }
        }
    }
}