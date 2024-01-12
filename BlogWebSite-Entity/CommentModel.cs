using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite_Entity
{
    public class CommentModel
    {
        [Key]
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool Status { get; set; } = false;
        public int BlogID { get; set; }
        public BlogModel Blog { get; set; }
    }
}
