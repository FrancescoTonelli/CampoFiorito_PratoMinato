using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PratoFiorito
{
    public class Campo
    {
        private int[,] _griglia;

        public int[,] Griglia = new int[8, 8];

        public Campo()
        {
            Riempi();
        }

        /*public int[,] Griglia
        {
            get
            {
                return _griglia;
            }
            set
            {
                _griglia = Griglia;
            }
        }*/

        Random r = new Random();

        public void Riempi() //casella = 0 -> niente, = n -> bombe nei paraggi, = -1 -> bomba
        {
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

            for (int n = 0; n < 8; n++)
            {
                for (int m = 0; m < 8; m++)
                {
                    if(Griglia[n, m] == -1)
                    {
                        if (n - 1 >= 0)
                        {
                            if (m - 1 >= 0)
                            {
                                if(Griglia[n - 1, m - 1]!=-1)
                                    Griglia[n - 1, m - 1]++;
                            }

                            if (m + 1 < 8)
                            {
                                if (Griglia[n - 1, m + 1] != -1)
                                    Griglia[n - 1, m + 1]++;
                            }

                            if (Griglia[n - 1, m] != -1)
                                Griglia[n - 1, m]++;
                        }

                        if (m - 1 >= 0)
                        {
                            if (Griglia[n, m - 1] != -1)
                                Griglia[n, m - 1]++;
                        }

                        if (m + 1 < 8)
                        {
                            if (Griglia[n, m + 1] != -1)
                                Griglia[n, m + 1]++;
                        }

                        if (n + 1 < 8)
                        {
                            if (m - 1 >= 0)
                            {
                                if (Griglia[n + 1, m - 1] != -1)
                                    Griglia[n + 1, m - 1]++;
                            }

                            if (m + 1 < 8)
                            {
                                if (Griglia[n + 1, m + 1] != -1)
                                    Griglia[n + 1, m + 1]++;
                            }

                            if (Griglia[n + 1, m] != -1)
                                Griglia[n + 1, m]++;
                        }
                    }
                }
            }
        }

        public string[] GetString()
        {
            string[] righe = new string[8];

            for (int n = 0; n < 8; n++)
            {
                for (int m = 0; m < 8; m++)
                {
                    if (m == 0 && Griglia[n, m]!=-1)
                    {
                        righe[n] += " ";
                    }
                    righe[n] += Griglia[n, m];
                    if (!(m == 7))
                    {
                        if (Griglia[n, m+1]==-1)
                        {
                            righe[n] += " ";
                        }
                        else
                        {
                            righe[n] += "  ";
                        }
                    }
                    
                }
            }

            return righe;
        }
    }
}