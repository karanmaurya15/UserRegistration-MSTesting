using System;
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
            bool matches = firstName.IsMatch(Name);

            return matches;
        }
    }
}
