using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cubit.Data.Models
{
    // View model
    public class PersonModel
    {
        [Display(Name="Name")]
        public string Name { get; set; }

        [Display(Name="Age")]
        public int Age { get; set; }

        [Display(Name="Height")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double Height { get; set; }

    }
}
