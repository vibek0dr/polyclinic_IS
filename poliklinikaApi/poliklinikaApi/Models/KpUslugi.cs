using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpUslugi
{
    public int KodUslugi { get; set; }

    public string Nazvanie { get; set; } = null!;

    public int Stoimost { get; set; }

    public string Image { get; set; } = null!;

    public virtual ICollection<KpUslugiZapisi> KpUslugiZapisis { get; set; } = new List<KpUslugiZapisi>();
}
