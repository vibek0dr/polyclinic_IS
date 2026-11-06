using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class CarBrand
{
    public int IdCarBrand { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Avto> Avtos { get; set; } = new List<Avto>();
}
