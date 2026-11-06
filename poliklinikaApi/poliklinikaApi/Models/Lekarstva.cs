using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Lekarstva
{
    public int IdLekarstva { get; set; }

    public string? Nazvanie { get; set; }

    public string? Kategoriya { get; set; }

    public decimal? CenaLekarstva { get; set; }

    public virtual ICollection<Apteka> Aptekas { get; set; } = new List<Apteka>();

    public virtual ICollection<Zayavka> Zayavkas { get; set; } = new List<Zayavka>();
}
