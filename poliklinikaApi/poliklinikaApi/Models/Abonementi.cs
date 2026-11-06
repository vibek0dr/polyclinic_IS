using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Abonementi
{
    public int IdAbonementa { get; set; }

    public int? VidTrenirovki { get; set; }

    public decimal Cena { get; set; }

    public int? KolichestvoPosesheniy { get; set; }

    public int? KolichestvoDney { get; set; }

    public int? KolichestvoMesyacev { get; set; }

    public string? VidUslugi { get; set; }

    public virtual ICollection<ProdajaAbonementov> ProdajaAbonementovs { get; set; } = new List<ProdajaAbonementov>();

    public virtual VidTrenirovlki? VidTrenirovkiNavigation { get; set; }
}
