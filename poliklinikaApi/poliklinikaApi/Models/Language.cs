using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Language
{
    public int IdLanguage { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Kniga1> Kniga1s { get; set; } = new List<Kniga1>();
}
