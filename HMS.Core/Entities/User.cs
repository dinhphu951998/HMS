using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
    }
}
