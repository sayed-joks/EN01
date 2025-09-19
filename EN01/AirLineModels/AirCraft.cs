using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    [Table("AirCraft")]
    internal class AirCraft
    {
        [Key]
        public int Id { get; set; }
        public string Capacity { get; set; }
        public string? Model { get; set; }
        public int Maj_pilot { get; set; }
        public string Assistant { get; set; }
        public int Host1 { get; set; }
        public int Host2 { get; set; }
        public int AL_Id { get; set; }
    }
}
