using System;
using System.Collections.Generic;

namespace Entity;

public partial class Doktorlar
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? UzmanlikAlani { get; set; }

    public string? TelefonNumarasi { get; set; }

    public bool? AktifMi { get; set; }

    public virtual ICollection<Randevular> Randevulars { get; set; } = new List<Randevular>();
}
