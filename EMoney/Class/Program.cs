namespace EMoney.Class
{
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
