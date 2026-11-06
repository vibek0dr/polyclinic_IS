using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Pacient
{
    public int NomerPolisa { get; set; }

    public int? Role { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public DateOnly? DataRojdeniya { get; set; }

    public int? IdKarti { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual KartaBolnogo? IdKartiNavigation { get; set; }

    public virtual ICollection<Priem> Priems { get; set; } = new List<Priem>();
}
