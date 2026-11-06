using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03User
{
    public int Kod { get; set; }

    public string Login { get; set; } = null!;

    public string Parol { get; set; } = null!;

    public int KodRoli { get; set; }

    public string Fio { get; set; } = null!;

    public bool Aktiven { get; set; }

    public DateTime? DataPoslednegoVhoda { get; set; }

    public string? Telefon { get; set; }

    public string? Pochta { get; set; }

    public virtual Up03Role KodRoliNavigation { get; set; } = null!;

    public virtual ICollection<Up03Sdelka> Up03Sdelkas { get; set; } = new List<Up03Sdelka>();
}
