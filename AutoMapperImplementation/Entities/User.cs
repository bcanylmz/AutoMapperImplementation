﻿namespace AutoMapperImplementation.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
