using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.ITIModels
{
    internal class Stud_Course
    {
        [Key]
        public int Stud_id { get; set; }
        public int Course_id { get; set; }
        public decimal Grade { get; set; }

    }
}
