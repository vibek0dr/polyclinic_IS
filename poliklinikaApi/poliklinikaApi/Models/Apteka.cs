using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Apteka
{
    public int IdApteki { get; set; }

    public int? IdLekarstva { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public virtual Lekarstva? IdLekarstvaNavigation { get; set; }
}
