using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string password { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

    }
}
