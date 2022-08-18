namespace TirupatiFinance.Models
{
    public sealed class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Language { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
