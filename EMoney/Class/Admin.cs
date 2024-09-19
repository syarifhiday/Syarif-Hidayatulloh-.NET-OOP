namespace EMoney.Class
{
    internal class Admin : User
    {
        public string AddSaldo(int amount, Customer customer)
        {
            customer.EmoneyUser += amount; // Tambahkan saldo ke customer
            return $"Saldo berhasil ditambahkan sebesar {amount} ke {customer.NameUser}. Saldo baru: {customer.EmoneyUser}";
        }
    }
}
