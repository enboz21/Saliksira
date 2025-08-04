using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Genderid { get; set; }
        public String? Gender { get; set; }
        public string Address { get; set; }
        [Required]
        public int DrId { get; set; }
        public string? DrName { get; set; }
        public string? Drsoyad { get; set; }

    }
}
