using System;
using System.Collections.Generic;

namespace Entity;

public partial class Randevular
{
    public int RandevuId { get; set; }

    public int? HastaId { get; set; }

    public int DoktorId { get; set; }

    public byte RandevuDurumu { get; set; }

    public virtual Doktorlar Doktor { get; set; } = null!;

    public virtual Hastalar? Hasta { get; set; }
}
