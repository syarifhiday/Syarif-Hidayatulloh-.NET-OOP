using System;

namespace Inheritance
{
    //parent class
    public class Lingkaran
    {
        double luas;
        //Method untuk menghitung luas
        public int luasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }

    //child class
    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung(int tinggi, double r)
        {
            volume = this.luasLingkaran(r) * tinggi;
        }

        public double getVolume()
        {
            return volume;
        }
        static void Main(string[] args)
        {
            //bikin object
            Tabung tabung = new Tabung(10, 7);

            //menampilkan volume
            Console.WriteLine("Volume tabung = "+ tabung.getVolume().ToString());
        }
    }
}