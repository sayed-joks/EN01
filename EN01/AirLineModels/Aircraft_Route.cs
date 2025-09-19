using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.AirLineModels
{
    internal class Aircraft_Route
    {
        [Key]
        public int Ac_Id { get; set; }
        public int Route_id { get; set; }
        public int Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public int Price { get; set; }
        public int Arrival { get; set; }
    }
}
