using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302ProizvodstvennyyKalendar
{
    public int KalendarId { get; set; }

    public DateOnly Data { get; set; }

    public string TipDnya { get; set; } = null!;

    public int NormaChasov { get; set; }

    public string? Kommentariy { get; set; }
}
