namespace EMoney.Class
{
    internal class User
    {
        private string name;
        private string role;
        private int emoney;

        public string NameUser { get { return name; } set { name = value; } }
        public string RoleUser { get { return role; } set { role = value; } }
        public int EmoneyUser { get { return emoney; } set { emoney = value; } }

    }
}
