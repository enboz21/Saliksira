using System;
using System.Collections.Generic;

namespace Entity;

public partial class MuayeneKuyrugu
{
    public int KuyrukId { get; set; }

    public int? RandevuId { get; set; }

    public int HastaId { get; set; }

    public int DoktorId { get; set; }

    public DateTime? GirisZamani { get; set; }

    public int? SiraNumarasi { get; set; }

    public string? KuyrukDurumu { get; set; }

    public DateTime? CikisZamani { get; set; }

    public virtual Doktorlar Doktor { get; set; } = null!;

    public virtual Hastalar Hasta { get; set; } = null!;

    public virtual Randevular? Randevu { get; set; }
}
