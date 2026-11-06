using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Klientt
{
    public int IdKlienta { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Zayavka> Zayavkas { get; set; } = new List<Zayavka>();
}
