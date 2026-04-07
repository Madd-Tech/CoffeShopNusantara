using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopNusantara.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string Code { get; set; } = string.Empty;
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; } = string.Empty;
        public string? Password { get; set; }   

    }
}
