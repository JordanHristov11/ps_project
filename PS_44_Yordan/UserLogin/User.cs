using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public int userId { get; set; }
        public string username{ get; set; }
        public string password { get; set; }
        public string facNum { get; set; }
        public UserRoles role { get; set; }
        public DateTime? creationTime { get; set; }
        public DateTime? expirationTime { get; set; }
    }
}
