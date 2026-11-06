using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Priem
{
    public int IdPriema { get; set; }

    public int? IdVracha { get; set; }

    public int? NomerKabineta { get; set; }

    public DateTime? DataVremyaPriema { get; set; }

    public int? NomerPolisa { get; set; }

    public virtual Vrach? IdVrachaNavigation { get; set; }

    public virtual Kabinet? NomerKabinetaNavigation { get; set; }

    public virtual Pacient? NomerPolisaNavigation { get; set; }
}
