namespace EMoney.Class
{
    internal class Customer : User
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
}
