using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Avtori
{
    public int IdAvtora { get; set; }

    public string FioAvtora { get; set; } = null!;

    public string DomTelAvt { get; set; } = null!;

    public string KontTelAvt { get; set; } = null!;

    public string SnPaspAvt { get; set; } = null!;

    public DateTime DataPaspAvt { get; set; }

    public string MestPaspAvt { get; set; } = null!;

    public string GorodAvtora { get; set; } = null!;

    public string AdresAvtora { get; set; } = null!;

    public string InnAvtora { get; set; } = null!;

    public virtual ICollection<AvtorKnigi> AvtorKnigis { get; set; } = new List<AvtorKnigi>();
}
