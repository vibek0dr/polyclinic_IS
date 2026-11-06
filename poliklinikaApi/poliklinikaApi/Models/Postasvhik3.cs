using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Postasvhik3
{
    public int IdPostasvshik { get; set; }

    public string? Nazvanie { get; set; }

    public string? Telephone { get; set; }

    public string? Adres { get; set; }

    public virtual ICollection<Tovar3> Tovar3s { get; set; } = new List<Tovar3>();
}
