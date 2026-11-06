using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Material
{
    public int IdMaterial { get; set; }

    public string Naimenovanie { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string EdIzmereniya { get; set; } = null!;

    public int Cena { get; set; }

    public virtual ICollection<_0209RashodMaterialov> _0209RashodMaterialovs { get; set; } = new List<_0209RashodMaterialov>();

    public virtual ICollection<_0209Specifikaciya> _0209Specifikaciyas { get; set; } = new List<_0209Specifikaciya>();
}
