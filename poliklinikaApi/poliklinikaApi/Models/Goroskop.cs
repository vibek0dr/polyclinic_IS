using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Goroskop
{
    public int IdGoroskop { get; set; }

    public int IdZodiak { get; set; }

    public string Text { get; set; } = null!;

    public virtual _1809ZodiakSign IdZodiakNavigation { get; set; } = null!;
}
