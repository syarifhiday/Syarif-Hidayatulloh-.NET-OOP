//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Object___Class
//{
//    internal class Program
//    {
//    }
//}

using System;

namespace UserManagement
{
    class User
    {
        //Atribute
        string nama = "Syarif";
        string role = "System Analyst";
        int e_money = 10000000;

        //Method
        public void UserDetail()
        {
            Console.WriteLine("ini detail usernya");
        }

        //Membuat object
        static void Main(string[] args)
        {
            //Kelas itu merupakan blueprint dari object
            User user = new User();
            user.UserDetail();
            Console.WriteLine("Nama : "+user.nama);
            Console.WriteLine("Role : "+user.role);
        }
    }
}