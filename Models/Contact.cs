namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }=String.Empty;
        public string Email { get; set; }=String.Empty;
        public long Phone { get; set; }
        public string Address { get; set; }=String.Empty;

    }
}