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
    public class Student : Person
    {
        [Required(ErrorMessage = "Faculty number required")]
        [MinLength(10, ErrorMessage = "Faculty number is 10 digits lenght!")]
        [MaxLength(10, ErrorMessage = "Faculty number is 10 digits lenght!")]
        [DisplayName("Факултетен номер")]
        public long Facuktetnumber { get; set; }

        [Required]
        [DisplayName("Форма на обучение")]
        public Forma Forms { get; set; }

        [Required]
        [DisplayName("Курс")]
        public int Course { get; set; }

        [Required]
        [DisplayName("Група")]
        public int Groups { get; set; }

        [Required]
        [DisplayName("Инспектор")]
        public string Inspector { get; set; }

        [Required]
        [DisplayName("ОКС")]
        public string OKS { get; set; }

        [Required]
        [DisplayName("Изображение")]
        [DataType(DataType.ImageUrl)]
        public string Inmage { get; set; }

        public virtual Specialty Specialnost { get; set; }
        public virtual Facultet Facultet { get; set; }
    }
}
