namespace IsmtJobportal.Entities
{
    public class User
    {
        public int id {  get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}
