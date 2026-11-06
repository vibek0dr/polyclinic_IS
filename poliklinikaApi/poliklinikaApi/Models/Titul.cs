using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Titul
{
    public int IdTitula { get; set; }

    public string NazvanieTitula { get; set; } = null!;

    public virtual ICollection<Sportsmeni> Sportsmenis { get; set; } = new List<Sportsmeni>();
}
