﻿namespace MiniBlogi.Models
{
    public class User
    {
        public int Id_user { get; set; }

        public string Name { get; set; }
        public string Surname {  get; set; }

        public string Email { get; set; }

        public string Nick {  get; set; }
        public string Password { get; set; }

        public string Type_account { get; set; }
    }
}
