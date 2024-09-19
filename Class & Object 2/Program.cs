using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 userBootcamp11 = new UserBootcamp11();
            userBootcamp11.NamaUser = "Aldo";
            userBootcamp11.RoleUser = "CEO";

            Console.WriteLine("Nama : "+userBootcamp11.NamaUser);
            Console.WriteLine("Role : "+userBootcamp11.RoleUser);
        }
    }
    public class UserBootcamp11
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser {  get; set; }
        public string RoleUser { get; set; }
        public int Emoney { get; set; }
    }
}