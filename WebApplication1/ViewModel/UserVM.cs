using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModel
{
    public class UserVM
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }
        public int  LevelId { get; set; }
        public int StatusId { get; set; }

    }
}