using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Klient
{
    public int Kod { get; set; }

    public string Fio { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string? Pochta { get; set; }

    public string? Adres { get; set; }

    public DateTime DataRegistratsii { get; set; }

    public string? Zametki { get; set; }

    public virtual ICollection<Up03Sdelka> Up03Sdelkas { get; set; } = new List<Up03Sdelka>();
}
