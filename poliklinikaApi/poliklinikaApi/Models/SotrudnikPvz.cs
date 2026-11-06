using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SotrudnikPvz
{
    public int IdSotrudnikPvz { get; set; }

    public string? Fio { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<PunktVidachi> PunktVidachis { get; set; } = new List<PunktVidachi>();
}
