using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Avto
{
    public int IdAvto { get; set; }

    public string? Name { get; set; }

    public int? CarBrand { get; set; }

    public string? Class { get; set; }

    public int? Vin { get; set; }

    public int? Cost { get; set; }

    public virtual CarBrand? CarBrandNavigation { get; set; }
}
