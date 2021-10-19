using MySocialNetwork.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.DTOs
{
    public class SecurityDTO
    {
        public string User { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleType? Role { get; set; }
    }
}
