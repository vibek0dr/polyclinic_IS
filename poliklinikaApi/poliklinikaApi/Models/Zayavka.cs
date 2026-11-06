using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zayavka
{
    public int IdZayavki { get; set; }

    public DateOnly? DataZayavki { get; set; }

    public int? IdProdavca { get; set; }

    public int? IdKlienta { get; set; }

    public int? IdLekarstva { get; set; }

    public virtual Klientt? IdKlientaNavigation { get; set; }

    public virtual Lekarstva? IdLekarstvaNavigation { get; set; }

    public virtual Prodavecc? IdProdavcaNavigation { get; set; }
}
