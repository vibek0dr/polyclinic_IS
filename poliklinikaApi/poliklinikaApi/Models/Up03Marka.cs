using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Marka
{
    public int Kod { get; set; }

    public string Nazvanie { get; set; } = null!;

    public string? Strana { get; set; }

    public virtual ICollection<Up03Model> Up03Models { get; set; } = new List<Up03Model>();
}
