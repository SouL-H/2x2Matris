using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class MatrisIslemleri
    {
        int _boyut = 0;
       public int[,] MatrisOlustur(int boyut)
        {
            int[,] dizi = new int[boyut, boyut];
            _boyut = boyut;
            Random rnd = new Random();
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    dizi[i, j] = rnd.Next(20);
                }
            }
            return dizi;
        }

        public void MatrisYazdir(int[,] matris,String name)
        {
            Console.WriteLine();
            Console.WriteLine("*****  " + name + " Matrisi  *****");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            for (int i = 0; i < _boyut; i++)
            {
                for (int j = 0; j < _boyut; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int[,] MatrisTopla(int[,] matris1, int[,] matris2)
        {
            int[,] dizi = new int[_boyut, _boyut];
            for (int i = 0; i < _boyut; i++)
            {
                for (int j = 0; j < _boyut; j++)
                {
                    dizi[i, j] = matris1[i,j] + matris2[i,j];
                }
            }
            return dizi;
        }

        public int[,] MatrisFark(int[,] matris1, int[,] matris2)
        {
            int[,] dizi = new int[_boyut, _boyut];
            for (int i = 0; i < _boyut; i++)
            {
                for (int j = 0; j < _boyut; j++)
                {
                    dizi[i, j] = matris1[i, j] - matris2[i, j];
                }
            }
            return dizi;
        }

        public int[,] MatrisCarp(int[,] matris1, int[,] matris2)
        {
            int[,] dizi = new int[_boyut, _boyut];
            for (int i = 0; i < _boyut; i++)
            {
                for (int j = 0; j < _boyut; j++)
                {
                    dizi[i, j] = matris1[i, j] * matris2[i, j];
                }
            }
            return dizi;
        }
    }
}
