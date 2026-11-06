using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Janr
{
    public int IdJanra { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
