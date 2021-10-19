using MySocialNetwork.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.Entities
{
    public class Security : BaseEntity
    {
        public string User { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
    }
}
