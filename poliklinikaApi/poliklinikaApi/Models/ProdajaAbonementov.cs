using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ProdajaAbonementov
{
    public int NomerKarti { get; set; }

    public DateOnly? DataNachala { get; set; }

    public DateOnly? DataOkonshaniya { get; set; }

    public int? KolishestvoOstasvhihsyaPosesheniy { get; set; }

    public int? IdAbonementa { get; set; }

    public int? IdKlienta { get; set; }

    public virtual Abonementi? IdAbonementaNavigation { get; set; }

    public virtual SpisokKlientov? IdKlientaNavigation { get; set; }

    public virtual ICollection<UshetPosesheniy> UshetPosesheniys { get; set; } = new List<UshetPosesheniy>();
}
