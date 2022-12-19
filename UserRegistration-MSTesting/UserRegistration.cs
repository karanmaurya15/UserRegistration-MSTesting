﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_MSTesting
{
    public class UserRegistration
    {
        public bool FirstName(string Name)
        {
            Regex firstName = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool regex = firstName.IsMatch(Name);
            return regex;
        }
        public bool LastName(string Name)
        {
            Regex lastName = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool regex = lastName.IsMatch(Name);
            return regex;
        }
        public bool EmailId(string email)
        {
            Regex emailID = new Regex(@"^(abc)[A-Za-z0-9_\+\-\.]*[@](bl)*[.](co)*[.][a-z]{2}$");
            bool regex = emailID.IsMatch(email);
            return regex;
        }
        public bool MobileNumber(string mobileNumber)
        {
            Regex number = new Regex(@"^\+[1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}$");
            bool regex = number.IsMatch(mobileNumber);
            return regex;
        }
        public bool Password(string password)
        {
            Regex pass = new Regex("^[A-za-z0-9]{8,}");
            bool regex = pass.IsMatch(password);
            return regex;
        }
    }
}
