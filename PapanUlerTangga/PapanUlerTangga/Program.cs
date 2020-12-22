using System;

namespace UlarTangga_Papan1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kotak = new string[100];
            for (int n = 0; n < 100; n++)
            {
                kotak[n] = "*";
            }
            int nomorkotak = 100;
            for (int m = 0; m < 10; m++) // 10x kebawah
            {
                for (int k = 0; k < 4; k++) // 4x kebawah
                {
                    for (int j = 0; j < 10; j++) // 10x ke kanan
                    {

                        if (k == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(kotak[nomorkotak - 1]);
                            }
                            Console.Write(nomorkotak);
                            nomorkotak--;
                        }
                        else if (k == 1)
                        {
                            Console.Write(kotak[nomorkotak - 1]);
                            Console.Write("1");
                            Console.Write("2");
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            nomorkotak--;
                        }
                        else if (k == 2)
                        {
                            Console.Write(kotak[nomorkotak - 1]);
                            Console.Write("3");
                            Console.Write("4");
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            nomorkotak--;
                        }
                        else
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Console.Write(kotak[nomorkotak - 1]);
                            }
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            nomorkotak--;
                        }


                    }
                    nomorkotak += 10;
                    Console.WriteLine();
                }
                nomorkotak -= 10;
                Console.WriteLine();
            }

        }
    }
}
