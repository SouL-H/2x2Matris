using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static int[,] ikinci;
        static int[,] birinci;
        static char islem;
        static char devam;
        static void Main(string[] args)
        {

            int boyut;
            MatrisIslemleri mt = new MatrisIslemleri();

            for (int i = 0; i < 2; i++) {
                Console.Write("Matris kaç boyutlu olacak(İki matris de aynı boyutta olmalı: ");
                boyut = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                { 
                    birinci = mt.MatrisOlustur(boyut);
                    mt.MatrisYazdir(birinci, "A");
                }
                else 
                { 
                    ikinci = mt.MatrisOlustur(boyut);
                    mt.MatrisYazdir(ikinci, "B");
                }
            }


            while (true)
            {
                Console.Write("\nBu iki matris üzerinde hangi işlem uygulansın? [+ - * ] ");
                islem = Convert.ToChar(Console.ReadLine());
                if (islem == '+' || islem == '-' || islem == '*')
                {
                    switch (islem)
                    {
                        case '+':
                            mt.MatrisYazdir(mt.MatrisTopla(birinci, ikinci), "Topla");
                            break;
                        case '-':
                            mt.MatrisYazdir(mt.MatrisFark(birinci, ikinci), "Fark");
                            break;
                        case '*':
                            mt.MatrisYazdir(mt.MatrisCarp(birinci, ikinci), "Çarp");
                            break;
                    }
                    Console.Write("Başka işlem yapmak istiyor musunuz? [eE-hH] ");
                    devam = Convert.ToChar(Console.ReadLine().ToLower());
                    if (devam == 'e')
                    {
                        continue;
                    }
                    if (devam == 'h')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen doğru karaktere basınız.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen doğru işlemi seçiniz\n");
                }
            }

        }
    }
}
