namespace Entity.DTOs
{
    public class OrDTOE
    {
        public int Id { get; set; }

        public string HastaAdi { get; set; } = null!;

        public string HastaSoyadi { get; set; } = null!;

        public string DoktorAdi { get; set; } = null!;

        public string DoktorSoyadi { get; set; } = null!;

        public String RandevuDurumu { get; set; }
    }
}
