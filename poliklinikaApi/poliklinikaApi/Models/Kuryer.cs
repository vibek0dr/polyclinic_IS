using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kuryer
{
    public int IdKuryer { get; set; }

    public string? Fio { get; set; }

    public string? Telephone { get; set; }

    public string? Adres { get; set; }

    public int? Zakaz { get; set; }

    public virtual ICollection<KuryerPvz> KuryerPvzs { get; set; } = new List<KuryerPvz>();

    public virtual Zakaz1? ZakazNavigation { get; set; }
}
