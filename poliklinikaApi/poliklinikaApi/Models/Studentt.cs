using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Studentt
{
    public int IdСтудента { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public DateOnly? DataRojdeniya { get; set; }

    public int? Gruppa { get; set; }

    public virtual Gruppaa? GruppaNavigation { get; set; }
}
