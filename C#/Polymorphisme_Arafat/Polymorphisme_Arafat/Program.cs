using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }

        class Menu
        {
            public void menu()
            {
                Console.WriteLine("PROGRAM MENGHITUNG LUAS DAN KELILING BANGUN DATAR");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Lingkaran");
                Console.WriteLine("3. Segitiga");

                Console.WriteLine();

                Persegi a = new Persegi();

                Console.WriteLine("1. Menghitung Persegi");
                Console.WriteLine("-------------------------");
                Console.Write("Sisi : ");
                a.sisi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas = {0} cm", a.hitungLuas());
                Console.WriteLine("Keliling = {0} cm", a.hitungKeliling());
                Console.WriteLine();

                Lingkaran d = new Lingkaran();

                Console.WriteLine("2. Menghitung Lingkaran");
                Console.WriteLine("-------------------------");
                Console.Write("Jari-Jari : ");
                d.jarijari = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas       = {0} cm", d.hitungLuas());
                Console.WriteLine("Keliling   = {0} cm", d.hitungKeliling());
                Console.WriteLine();

                Segitiga c = new Segitiga();

                Console.WriteLine("3. Menghitung Segitiga");
                Console.WriteLine("------------------------");
                Console.Write("Alas   : ");
                c.alas = (int.Parse(Console.ReadLine()));
                Console.Write("Tinggi : ");
                c.tinggi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas   = {0} cm", c.hitungLuas());
                Console.Write("Sisi : ");
                c.sisi2 = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Keliling   = {0} cm", c.hitungKeliling());
                Console.ReadKey();
            }

            public abstract class BangunDatar
            {
                public double _hitung;

                public double Hitung
                {
                    get { return _hitung; }
                    set { _hitung = value; }
                }

                public abstract double hitungLuas();

                public abstract double hitungKeliling();
            }

            public class Persegi : BangunDatar
            {
                private double s;

                public double sisi
                {
                    get { return s; }
                    set { s = value; }
                }

                public Persegi()
                {
                    this.sisi = sisi;
                }

                public override double hitungLuas()
                {
                    return this.sisi * this.sisi;
                }
                public override double hitungKeliling()
                {
                    return this.sisi * 4;
                }
            }

            public class Segitiga
            {
                private float a, t, x;

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
                public float sisi2
                {
                    get { return x; }
                    set
                    {
                        x = value;
                    }
                }

                public Segitiga()
                {
                    this.alas = alas;
                    this.tinggi = tinggi;
                }
                public float hitungLuas()
                {
                    return this.alas * this.tinggi / 2;
                }
                public float hitungKeliling()
                {
                    return this.sisi2 + this.sisi2 + this.sisi2;
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
                public Lingkaran()
                {
                    this.jarijari = r;
                }

                public override double hitungLuas()
                {
                    return (float)(Math.PI * r * r);
                }

                public override double hitungKeliling()
                {
                    return (float)(2 * Math.PI * r);
                }
            }
        }
    }
}