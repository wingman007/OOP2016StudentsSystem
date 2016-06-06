using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person : BaceModel
    {
        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("ЕГН")]
        public long EGN { get; set; }

        [Required]
        [DisplayName("Е-майл")]
        public string Email { get; set; }

    }
}
