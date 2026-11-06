using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class CarOrder
{
    public int IdCarOrder { get; set; }

    public int? IdUser { get; set; }

    public int? IdSeller { get; set; }

    public int? IdAvto { get; set; }

    public DateOnly? Date { get; set; }

    public string? Status { get; set; }

    public virtual Avto? IdAvtoNavigation { get; set; }

    public virtual CarSeller? IdSellerNavigation { get; set; }

    public virtual UserAvt1? IdUserNavigation { get; set; }
}
