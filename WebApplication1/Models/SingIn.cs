using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Enum;

namespace WebApplication1.Models
{
    public class SingIn : BaceModel
    {

        [Required]
        [DisplayName("Парола")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Име")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("E-майл")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Дата на раждане")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        [Required]
        [DisplayName("Телефон")]
        public long Mobile { get; set; }

    }
}
