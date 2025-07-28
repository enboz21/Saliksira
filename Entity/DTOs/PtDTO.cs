using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class PtDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public DateOnly? BirthDate { get; set; }
        public String PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

    }
}
