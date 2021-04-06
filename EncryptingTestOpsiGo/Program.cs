using System;
using System.Collections.Generic;

namespace EncryptingTestOpsiGo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesan = "maafAkuenggak";
            pesan_rahasia(pesan);
            // int batasX = 4;


            //for (int all = 0; all < pesan.Length; all++)
            //{
            //int row = 0;
            //int Kolom = 0;
            //for (int i = 0; i < M-1;++i)
            //{
            //    for (int j = 0; j<M; ++j)
            //    {
            //    Console.WriteLine(i + "" + j);
            //    //  a.Add((i, j) , pesan[batasX-1-tabelY].ToString() );
            //}

            //}
            //}

        }

        //public static string encrypt(Dictionary<(int,int),string> matrix)
        //{
        //    for (int i = 0; i < matrix.GetValueOrDefault(); i++)
        //    {

        //    }

        //    return output;
        //}

        public static string pesan_rahasia(string pesan)
        {
            string x = "";

            int L = pesan.Length;
            object M_base = Math.Sqrt(Convert.ToDouble(L));
            int M = (int) Math.Floor(Convert.ToDecimal(M_base));
            if (M_base is double)
            {
                M += 1;
            }

            int M_fix = Convert.ToInt16(M);
            int TandaBintang = ((M_fix * M_fix) - L);
            
            string[,] b = new string[M_fix,M_fix];

            for (int i = 0; i < TandaBintang; i++)
            {
                pesan += "*";
            }

            int reader1 = 0;

            for (int i = 0; i < M_fix; i++)
            {
                for (int j = 0; j < M_fix; j++)
                {
                    b[i, j] = pesan.ToCharArray().GetValue(reader1).ToString();
                    reader1++;
                }
            }

            for (int i = 0; i < M_fix; i++)
            {
                for (int j = 0; j < M_fix; j++)
                {
                    Console.Write(b[i, j]);
                }
            }

            Console.WriteLine("");

            string[,] c = new string[M_fix,M_fix];
            string pesanOutput = "";
            for (int i = 0; i < M_fix; i++)
            {
                for (int j = 0; j < M_fix; j++)
                {
                    int rowBaru,kolomBaru;

                    kolomBaru = i;
                    rowBaru = (M_fix - 1) - j;
                    c[i, j] = b[rowBaru, kolomBaru];
                    if (b[rowBaru, kolomBaru] != "*")
                    {
                        pesanOutput += c[i, j];
                    }
                    
                }
            }


            Console.Write(pesanOutput + "");
            Console.ReadKey();

            return x;
        }
    }
}
