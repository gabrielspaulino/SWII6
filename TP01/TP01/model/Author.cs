using System;
using System.Collections.Generic;
using System.Text;

namespace TP01.model
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(String name, String email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public char getGender()
        {
            return gender;
        }

        public override string ToString()
        {
            return "Author[name = " + name + ", email = " + email + ", gender = " + gender + "]";
        }
    }
}
