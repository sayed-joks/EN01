using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    [Table("AirLinePhones")]
    internal class AirLinePhones
    {
        [Key]
        public int AL_Id { get; set; }
        [Phone]
        public int Phones { get; set; }
    }
}
