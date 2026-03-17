namespace Sklad1.Data
{
    internal class User
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public string role { get; set; }
    }
}
