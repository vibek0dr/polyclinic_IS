using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Klient1
{
    public int IdKilent { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public DateOnly DataRojdenie { get; set; }

    public string? Passport { get; set; }

    public string? MedicinskiyPolis { get; set; }

    public string? Snils { get; set; }

    public virtual ICollection<Zakaz1> Zakaz1s { get; set; } = new List<Zakaz1>();
}
