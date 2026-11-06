using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Gruppaa
{
    public int IdGruppa { get; set; }

    public string? Nazvanie { get; set; }

    public int? Otdelenie { get; set; }

    public virtual Otdeleniye? OtdelenieNavigation { get; set; }

    public virtual ICollection<Studentt> Studentts { get; set; } = new List<Studentt>();
}
