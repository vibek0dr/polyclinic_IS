using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tovar2
{
    public int IdTovar { get; set; }

    public string? Nazvanie { get; set; }

    public string? Cena { get; set; }

    public string? Ves { get; set; }

    public int? Prodavec { get; set; }

    public virtual Prodavec? ProdavecNavigation { get; set; }

    public virtual ICollection<TovarZakaz11> TovarZakaz11s { get; set; } = new List<TovarZakaz11>();
}
