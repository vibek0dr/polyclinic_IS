using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Klienti
{
    public int IdKlienta { get; set; }

    public int? IdPutevki { get; set; }

    public DateOnly? DataOformleniya { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public int? NomerPassporta { get; set; }

    public string? Kommentarii { get; set; }

    public string? Password { get; set; }

    public string? Login { get; set; }

    public int? IdRole { get; set; }

    public virtual Putevki? IdPutevkiNavigation { get; set; }
}
