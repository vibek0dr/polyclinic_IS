using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Sdelka
{
    public int Kod { get; set; }

    public int KodAvtomobilya { get; set; }

    public int KodKlienta { get; set; }

    public int KodProdavtsa { get; set; }

    public DateTime DataSdelki { get; set; }

    public decimal ItogovayaCena { get; set; }

    public string NomerDogovora { get; set; } = null!;

    public string? SposobOplaty { get; set; }

    public string? Kommentarii { get; set; }

    public decimal Skidka { get; set; }

    public virtual Up03Avtomobil KodAvtomobilyaNavigation { get; set; } = null!;

    public virtual Up03Klient KodKlientaNavigation { get; set; } = null!;

    public virtual Up03User KodProdavtsaNavigation { get; set; } = null!;
}
