using System;
using System.Collections.Generic;

namespace Entity;

public partial class Randevular
{
    public int RandevuId { get; set; }

    public int HastaId { get; set; }

    public int DoktorId { get; set; }

    public DateOnly RandevuTarihi { get; set; }

    public TimeOnly RandevuSaati { get; set; }

    public string? RandevuDurumu { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public virtual Doktorlar Doktor { get; set; } = null!;

    public virtual Hastalar Hasta { get; set; } = null!;

    public virtual ICollection<MuayeneKuyrugu> MuayeneKuyrugus { get; set; } = new List<MuayeneKuyrugu>();
}
