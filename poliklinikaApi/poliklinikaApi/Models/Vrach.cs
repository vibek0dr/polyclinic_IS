using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Vrach
{
    public int IdVracha { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public int? NomerKabineta { get; set; }

    public TimeOnly? ChasiPriemaS { get; set; }

    public TimeOnly? ChasiPriemaDo { get; set; }

    public virtual ICollection<Priem> Priems { get; set; } = new List<Priem>();
}
