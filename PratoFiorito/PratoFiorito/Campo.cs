using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PratoFiorito
{
    public class Campo
    {
        public int[,] griglia = new int[8, 8];

        public Campo()
        {
            Riempi();
        }

        Random r = new Random();

        public void Riempi() //casella = 0 -> niente, = n -> bombe nei paraggi, = -1 -> bomba
        {
            int i = 10;

            for(int n = 0; n < griglia.GetLength(0); n++)
            {
                for (int m = 0; m < griglia.GetLength(1); m++)
                {
                    griglia[n, m] = 0;
                }
            }

            while (i != 0)
            {
                int x = r.Next(0, 8);
                int y = r.Next(0, 8);

                if(griglia[x,y] != -1)
                {
                    griglia[x, y] = -1;
                    i--;
                }
            }

            for (int n = 0; n < 8; n++)
            {
                for (int m = 0; m < 8; m++)
                {
                    if(griglia[n, m] == -1)
                    {
                        if (n - 1 >= 0)
                        {
                            if (m - 1 >= 0)
                            {
                                if(griglia[n - 1, m - 1]!=-1)
                                    griglia[n - 1, m - 1]++;
                            }

                            if (m + 1 < 8)
                            {
                                if (griglia[n - 1, m + 1] != -1)
                                    griglia[n - 1, m + 1]++;
                            }

                            if (griglia[n - 1, m] != -1)
                                griglia[n - 1, m]++;
                        }

                        if (m - 1 >= 0)
                        {
                            if (griglia[n, m - 1] != -1)
                                griglia[n, m - 1]++;
                        }

                        if (m + 1 < 8)
                        {
                            if (griglia[n, m + 1] != -1)
                                griglia[n, m + 1]++;
                        }

                        if (n + 1 < 8)
                        {
                            if (m - 1 >= 0)
                            {
                                if (griglia[n + 1, m - 1] != -1)
                                    griglia[n + 1, m - 1]++;
                            }

                            if (m + 1 < 8)
                            {
                                if (griglia[n + 1, m + 1] != -1)
                                    griglia[n + 1, m + 1]++;
                            }

                            if (griglia[n + 1, m] != -1)
                                griglia[n + 1, m]++;
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
                    if (m == 0 && griglia[n, m]!=-1)
                    {
                        righe[n] += " ";
                    }
                    righe[n] += griglia[n, m];
                    if (!(m == 7))
                    {
                        if (griglia[n, m+1]==-1)
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