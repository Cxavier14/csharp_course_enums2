﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Enum.Entities
{
    class Client
    {
        // propriedades
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // construtores
        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
