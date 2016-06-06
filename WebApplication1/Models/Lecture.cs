using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Lecture : Person
    {
        private ICollection<Subject> predmet;

        public Lecture()
        {
            this.predmet = new HashSet<Subject>();
        }
        [Required]
        [DisplayName("Кабинет")]
        public int Kabinet { get; set; }

        [Required]
        [DisplayName("Телефон")]
        public long Modile { get; set; }

        public virtual ICollection<Subject> Predmet
        {
            get
            {
                return this.predmet;
            }
            set
            {
                this.predmet = value;
            }
        }


    }


}

