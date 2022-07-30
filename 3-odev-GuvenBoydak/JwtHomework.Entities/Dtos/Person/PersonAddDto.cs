﻿namespace JwtHomework.Entities
{
    public class PersonAddDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int AccountId { get; set; }
    }
}
