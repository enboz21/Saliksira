using Core;
using System;
using System.Collections.Generic;

namespace Entity;

public partial class Randevular : IEntity
{
    public int Id { get; set; }

    public int? HastaId { get; set; }

    public int DoktorId { get; set; }

    public byte RandevuDurumu { get; set; }

    public virtual Doktorlar Doktor { get; set; } = null!;

    public virtual Hastalar? Hasta { get; set; }

    public virtual Durum RandevuDurumuNavigation { get; set; } = null!;
}
