using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class VidRaboti
{
    public int IdVidaRaboti { get; set; }

    public string? Naimenovanie { get; set; }

    public string? CenaEd { get; set; }

    public virtual ICollection<Zakaz4> Zakaz4s { get; set; } = new List<Zakaz4>();
}
