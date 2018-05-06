using GossserandProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GossserandProject.Data.Models.User
	
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
