using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Polushateli
{
    public int IdPolushatel { get; set; }

    public string? Organizaciya { get; set; }

    public int? IdGoroda { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Zakazi> Zakazis { get; set; } = new List<Zakazi>();
}
