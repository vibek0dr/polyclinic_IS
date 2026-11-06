using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Klient
{
    public int IdKlient { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public string? Adress { get; set; }

    public string? Telephone { get; set; }

    public int? ProcentSkidki { get; set; }

    public virtual ICollection<Zakaz4> Zakaz4s { get; set; } = new List<Zakaz4>();
}
