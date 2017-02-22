using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRM.Web { 
    public class UserContext
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public System.DateTime? StartDate { get; set; }
        public int Role { get; set; }
    }
}