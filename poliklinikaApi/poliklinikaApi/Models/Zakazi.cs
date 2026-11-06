using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakazi
{
    public int IdZakaza { get; set; }

    public int? NomerNakladnoy { get; set; }

    public DateOnly? DataZakaza { get; set; }

    public DateOnly? DataOtgruzki { get; set; }

    public int? IdPolushatel { get; set; }

    public virtual Polushateli? IdPolushatelNavigation { get; set; }
}
