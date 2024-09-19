using System;

namespace Encapsulation
{
    //Class lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        //private field untuk menyimpan nilai radius
        private double radius;

        //public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari nol");
                }
            }
        }
        //method buat hitung luas lingkaran
        public double Luas()
        {
            return 3.14 * radius * radius;
        }
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;
            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius;
                this.tinggi = tinggi;
            }
            public double hitungVolume()
            {
                return lingkaran.Luas() * tinggi;
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(10, 5);
                    Console.WriteLine("Volume tabung : " + tabung.hitungVolume().ToString());
                }catch(Exception e)
                { Console.WriteLine(e.Message); }
            }
        }
        
    }
}

