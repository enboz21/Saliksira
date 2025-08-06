using Core;

namespace Entity;

public partial class Cin : IEntity
{
    public byte Id { get; set; }

    public string Cinsiyet { get; set; } = null!;

    public virtual ICollection<Hastalar> Hastalars { get; set; } = new List<Hastalar>();
}
