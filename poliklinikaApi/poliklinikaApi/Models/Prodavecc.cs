using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Prodavecc
{
    public int IdProdavca { get; set; }

    public string? Imya { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Zayavka> Zayavkas { get; set; } = new List<Zayavka>();
}
