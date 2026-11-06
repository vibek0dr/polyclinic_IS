using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Rejiseri
{
    public int IdRejisera { get; set; }

    public string? Imya { get; set; }

    public string? Familiya { get; set; }

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
