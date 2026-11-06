using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Bilet
{
    public int IdBileta { get; set; }

    public int? Passajir { get; set; }

    public int? Vagon { get; set; }

    public DateOnly? DataPokupki { get; set; }

    public DateOnly? DataOtpravleniya { get; set; }

    public string? PunktOtpravleniya { get; set; }

    public string? PunktNaznacheniya { get; set; }

    public virtual Passajir? PassajirNavigation { get; set; }

    public virtual Vagon? VagonNavigation { get; set; }
}
