using System;
using System.Collections.Generic;

namespace Entity;

public partial class Durum
{
    public byte Id { get; set; }

    public string Durum1 { get; set; } = null!;

    public virtual ICollection<Randevular> Randevulars { get; set; } = new List<Randevular>();
}
