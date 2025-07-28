// Entity/DTOs/RandevuBasitRaporDto.cs
// Veya Entity/RandevuBasitRaporDto.cs (Eğer DTOs klasörü istemiyorsan)

using System; // Eğer tarih gibi tipler kullanacaksan
using System.Collections.Generic; // Eğer liste gibi tipler kullanacaksan
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs // Eğer DTOs klasörü oluşturduysan
// namespace Entity // Eğer DTOs klasörü istemiyorsan, direkt Entity namespace'i altında
{
    public class ApDto
    {
        // SQL sorgusundan gelen "RandevuId" alanına karşılık
        public int RandevuId { get; set; }

        // SQL sorgusundan gelen "HastaAdi" alanına karşılık
        public string HastaAdi { get; set; } = null!; // null! ile C# 8.0'daki nullable uyarılarını sustururuz

        // SQL sorgusundan gelen "HastaSoyadi" alanına karşılık
        public string HastaSoyadi { get; set; } = null!;

        // SQL sorgusundan gelen "DoktorAdi" alanına karşılık
        public string DoktorAdi { get; set; } = null!;

        // SQL sorgusundan gelen "DoktorSoyadi" alanına karşılık
        public string DoktorSoyadi { get; set; } = null!;

        // SQL sorgusundan gelen "RandevuDurumuId" alanına karşılık (DS.id olarak seçtiğin için byte)
        public String RandevuDurumu { get; set; }
    }
}