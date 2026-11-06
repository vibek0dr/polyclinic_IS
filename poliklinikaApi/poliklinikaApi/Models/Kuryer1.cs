using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kuryer1
{
    public int IdKuryer { get; set; }

    public string? Fio { get; set; }

    public string? Telephone { get; set; }

    public string? Transport { get; set; }

    public int? Zakaz { get; set; }

    public virtual Zakaz2? ZakazNavigation { get; set; }
}
