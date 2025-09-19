using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    internal class Route
    {
        [Key]
        public int Id { get; set; }
        public int Distance { get; set; }
        public int Destination { get; set; }
        public string Origin { get; set; }
        public string Classfication { get; set; }
    }
}
