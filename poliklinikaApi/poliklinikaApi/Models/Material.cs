using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Material
{
    public int IdMaterial { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Jewel> Jewels { get; set; } = new List<Jewel>();
}
