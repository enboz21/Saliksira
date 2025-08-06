using Core;

namespace Entity;

public partial class Hastalar : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? TckimlikNo { get; set; }

    public DateOnly? DogumTarihi { get; set; }

    public byte? Cinsid { get; set; }

    public string? TelefonNumarasi { get; set; }

    public string? Adres { get; set; }

    public int Doktorid { get; set; }

    public virtual Cin? Cins { get; set; }

    public virtual Doktorlar Doktor { get; set; } = null!;

    public virtual ICollection<Randevular> Randevulars { get; set; } = new List<Randevular>();
}
