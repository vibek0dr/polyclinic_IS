using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sotrudnikii
{
    public int IdSotrudnika { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public string Telephone { get; set; } = null!;

    public int Doljnost { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual Doljnostt DoljnostNavigation { get; set; } = null!;

    public virtual ICollection<Otdel> OtdelRukovoditelNavigations { get; set; } = new List<Otdel>();

    public virtual ICollection<Otdel> OtdelSotrudnikiNavigations { get; set; } = new List<Otdel>();
}
