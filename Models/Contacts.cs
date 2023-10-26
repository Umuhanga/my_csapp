using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace contactbook.Models
{
    public class Contacts
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Surname { get; set; }

        public string Email { get; set; }

        [DisplayName("Phone number")]
        public int PhoneNumber { get; set; }

        [DisplayName("Birth date")]
        public int Birth { get; set; }
    }
}
