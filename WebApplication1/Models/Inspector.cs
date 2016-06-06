using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Inspector : Person
    {
        
        [DataType(DataType.Password)]
        public string AlpaCode { get; set; }
    }
}
