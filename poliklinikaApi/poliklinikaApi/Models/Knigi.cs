using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Knigi
{
    public int Isbn { get; set; }

    public int? IdKategorii { get; set; }

    public string? NazvanieKnigi { get; set; }

    public int? KolichestvoStranic { get; set; }

    public string? Annotaciya { get; set; }

    public int? Tirag { get; set; }

    public int? CenaExemplyara { get; set; }

    public string? AvtorskiiZnak { get; set; }

    public string? Izdanie { get; set; }

    public virtual ICollection<AvtorKnigi> AvtorKnigis { get; set; } = new List<AvtorKnigi>();

    public virtual Kategorii? IdKategoriiNavigation { get; set; }
}
