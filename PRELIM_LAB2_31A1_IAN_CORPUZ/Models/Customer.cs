namespace PRELIM_LAB2_31A1_IAN_CORPUZ.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
