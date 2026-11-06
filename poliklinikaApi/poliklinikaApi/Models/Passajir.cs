using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Passajir
{
    public int IdPassajira { get; set; }

    public string? Fio { get; set; }

    public string? Telephone { get; set; }

    public int? TipDocumenta { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();

    public virtual TipDocumentum? TipDocumentaNavigation { get; set; }
}
