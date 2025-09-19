using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    internal class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amout { get; set; }
        public DateOnly Date { get; set; }
        public int AL_Id { get; set; }
    }
}
