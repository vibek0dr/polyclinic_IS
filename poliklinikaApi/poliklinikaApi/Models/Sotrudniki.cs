using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sotrudniki
{
    public int IdSotrudnika { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public string? PasportnieDannie { get; set; }

    public string? Adress { get; set; }

    public string? Telephone { get; set; }

    public string? ProcentVoznagrojdeniya { get; set; }

    public virtual ICollection<Zakaz4> Zakaz4s { get; set; } = new List<Zakaz4>();
}
