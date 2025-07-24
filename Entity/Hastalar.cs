using System;
using System.Collections.Generic;

namespace Entity;

public partial class Hastalar
{
    public int HastaId { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? TckimlikNo { get; set; }

    public DateOnly? DogumTarihi { get; set; }

    public string? Cinsiyet { get; set; }

    public string? TelefonNumarasi { get; set; }

    public string? Adres { get; set; }

    public virtual ICollection<Randevular> Randevulars { get; set; } = new List<Randevular>();
}
