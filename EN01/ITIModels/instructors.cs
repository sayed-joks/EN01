using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.ITIModels
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public int Hour_Rate { get; set; }
        public int Dep_id { get; set; }

    }
}
