using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakaz4
{
    public int IdZakaza { get; set; }

    public int? IdKlient { get; set; }

    public int? IdSotrudnik { get; set; }

    public DateOnly? DataOformleniya { get; set; }

    public DateOnly? DataIspolneniya { get; set; }

    public int? IdStatus { get; set; }

    public int? IdVidRaboti { get; set; }

    public int? KolVoEdenic { get; set; }

    public int? Cena { get; set; }

    public virtual Klient? IdKlientNavigation { get; set; }

    public virtual Sotrudniki? IdSotrudnikNavigation { get; set; }

    public virtual Status1? IdStatusNavigation { get; set; }

    public virtual VidRaboti? IdVidRabotiNavigation { get; set; }
}
