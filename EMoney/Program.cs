using System;

namespace EMoney
{
    public class User
    {
        private string name;
        private string role;
        private int emoney;

        public string NameUser { get { return name; } set { name = value; } }
        public string RoleUser { get { return role; } set { role = value; } }
        public int EmoneyUser { get { return emoney; } set { emoney = value; } }

    }

    public class Admin : User
    {
        public string AddSaldo(int amount, Customer customer)
        {
            customer.EmoneyUser += amount; // Tambahkan saldo ke customer
            return $"Saldo berhasil ditambahkan sebesar {amount} ke {customer.NameUser}. Saldo baru: {customer.EmoneyUser}";
        }
    }

    public class Customer : User
    {
        private int default_money = 1000; // Default saldo customer

        // Override EmoneyUser untuk selalu mengambil default value
        public new int EmoneyUser
        {
            get { return default_money; }
            set { default_money = value; }
        }

        public string ViewSaldo()
        {
            return $"Saldo : {EmoneyUser}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Customer aldo = new Customer { NameUser = "Aldo", RoleUser = "Customer" };
            Customer arif = new Customer { NameUser = "Arif", RoleUser = "Customer" };

            Admin admin = new Admin { NameUser = "Syairf", RoleUser = "Admin" };

            Console.WriteLine("Masukan role anda (admin/customer) : ");
            string role = Console.ReadLine();

            if (role.ToLower() == "admin")
            {
                Console.WriteLine("Pilih customer (aldo/arif) : ");
                string customer = Console.ReadLine();
                Customer selectedCustomer = customer == "aldo" ? aldo : customer == "arif" ? arif : null;

                if (selectedCustomer != null)
                {
                    Console.WriteLine("Nama : " + selectedCustomer.NameUser);
                    Console.WriteLine("Role : " + selectedCustomer.RoleUser);
                    Console.WriteLine("Saldo saat ini: " + selectedCustomer.EmoneyUser);

                    Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan: ");
                    int saldoTambahan;
                    if (int.TryParse(Console.ReadLine(), out saldoTambahan))
                    {
                        Console.WriteLine(admin.AddSaldo(saldoTambahan, selectedCustomer));
                    }
                    else
                    {
                        Console.WriteLine("Input tidak valid, saldo tidak ditambahkan.");
                    }
                }
                else
                {
                    Console.WriteLine("Customer tidak ada.");
                }
            }
            else if (role.ToLower() == "customer")
            {
                Console.WriteLine("Pilih customer (aldo/arif) : ");
                string customer = Console.ReadLine();
                Customer selectedCustomer = customer == "aldo" ? aldo : customer == "arif" ? arif : null;

                if (selectedCustomer != null)
                {
                    Console.WriteLine("Nama : " + selectedCustomer.NameUser);
                    Console.WriteLine("Role : " + selectedCustomer.RoleUser);
                    Console.WriteLine(selectedCustomer.ViewSaldo());
                }
                else
                {
                    Console.WriteLine("Customer tidak ada.");
                }
            }
            else
            {
                Console.WriteLine("Role tidak valid.");
            }
        }
    }
}
