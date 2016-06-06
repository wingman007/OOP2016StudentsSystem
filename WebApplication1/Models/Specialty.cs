using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Specialty : BaceModel
    {
        private ICollection<Lecture> lectures;

        public Specialty()
        {
            this.lectures = new HashSet<Lecture>();
        }
        [Range(1, 4.0)]
        [Required]
        [DisplayName("Време на обучение")]
        public int YearOFStudy { get; set; }
        

        [Required]
        [DisplayName("Инспектор")]
        public string Inspector { get; set; }

        [Required]
        [DisplayName("ОКС")]
        public string OKS { get; set; }


        public virtual ICollection<Lecture> Lecture
        {
            get
            {
                return this.lectures;
            }
            set
            {
                this.lectures = value;
            }
        }

    }
}
