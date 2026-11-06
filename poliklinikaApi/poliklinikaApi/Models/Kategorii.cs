using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kategorii
{
    public int IdKategorii { get; set; }

    public string NameKategorii { get; set; } = null!;

    public virtual ICollection<Knigi> Knigis { get; set; } = new List<Knigi>();
}
