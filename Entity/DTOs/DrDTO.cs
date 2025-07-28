using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class DrDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public String Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public bool vailability { get; set; } // 0: Not Available, 1: Available
    }
}
