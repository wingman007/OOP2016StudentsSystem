using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BaceModel
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Име")]
        public string Name { get; set; }
    }
}
