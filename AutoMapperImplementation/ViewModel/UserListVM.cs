namespace AutoMapperImplementation.ViewModel
{
    public class UserListVM
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string GetFullName() { return $"{FirstName} {LastName}"; }
    }
}
