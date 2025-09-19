using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    internal class Emp_Qualifications
    {
        [Key]
        public int Emp_id { get; set; }
        public string Qualifications { get; set; }

    }
}
