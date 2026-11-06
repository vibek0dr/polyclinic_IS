using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class UshetPosesheniy
{
    public int NomerPosesheniya { get; set; }

    public int NomerKarti { get; set; }

    public int NomerZapisi { get; set; }

    public virtual ProdajaAbonementov NomerKartiNavigation { get; set; } = null!;

    public virtual Raspisaniyee NomerZapisiNavigation { get; set; } = null!;
}
