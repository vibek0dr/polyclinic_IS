using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Student
{
    public int IdStudenta { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public int Gruppa { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Grupp GruppaNavigation { get; set; } = null!;

    public virtual ICollection<Ocenkii> Ocenkiis { get; set; } = new List<Ocenkii>();
}
