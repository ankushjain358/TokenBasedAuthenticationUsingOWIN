using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenBasedAuthenticationUsingOWIN.Models
{
    public class AuthRepository
    {
        public bool ValidateUser(string username, string password)
        {
            //TODO: Logic to validate username & password from database
            return true;
        }
    }
}