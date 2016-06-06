using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Subject : BaceModel
    {
        [Required]
        [DisplayName("Курс")]
        public int Course { get; set; }

        [Required]
        [DisplayName("Семестър")]
        public int Semester { get; set; }

        public virtual Lecture Lecture { get; set; }

    }
}
