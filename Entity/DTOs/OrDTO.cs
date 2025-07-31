using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class OrDTO
    {
        public int Id { get; set; }

        public int? HastaId { get; set; }

        public int DoktorId { get; set; }

        public byte RandevuDurumuId { get; set; }

        public string HastaAdi { get; set; } = null!;

        public string HastaSoyadi { get; set; } = null!;

        public string DoktorAdi { get; set; } = null!;

        public string DoktorSoyadi { get; set; } = null!;

        public String RandevuDurumu { get; set; }
    }
}
