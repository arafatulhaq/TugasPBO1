using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM MENGHITUNG LUAS DAN KELILING BANGUN DATAR");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Segitiga");

            Console.WriteLine();

            BangunDatar bangunDatar = new BangunDatar();

            Persegi a = new Persegi();
            a.sisi = 2;

            Lingkaran d = new Lingkaran();
            d.jarijari = 22;

            PersegiPanjang b = new PersegiPanjang();
            b.panjang = 8;
            b.lebar = 4;

            Segitiga c = new Segitiga();
            c.alas = 12;
            c.tinggi = 8;

            bangunDatar.luas();
            bangunDatar.keliling();

            a.luas();
            a.keliling();

            d.luas();
            d.keliling();

            b.luas();
            b.keliling();

            c.luas();
            c.keliling();
        }

        public class BangunDatar
        {
            internal float luas()
            {
                Console.WriteLine("Menghitung luas bangun datar");
                return 0;
            }

            internal float keliling()
            {
                Console.WriteLine("Menghitung keliling bangun datar");
                return 0;
            }
        }

        public class Persegi : BangunDatar
        {
            private double s;
            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
        }

        public class Lingkaran : BangunDatar
        {
            private double r;

            public double jarijari
            {
                get { return r; }
                set
                {
                    r = value;
                }
            }

        }

        public class PersegiPanjang : BangunDatar
        {
            private float p, l;

            public float panjang
            {
                get { return p; }
                set
                {
                    p = value;
                }
            }

            public float lebar
            {
                get { return l; }
                set
                {
                    l = value;
                }
            }
        }

        public class Segitiga : BangunDatar
        {
            private float a, t;

            public float alas
            {
                get { return a; }
                set
                {
                    a = value;
                }
            }

            public float tinggi
            {
                get { return t; }
                set
                {
                    t = value;
                }
            }
        }
    }
}