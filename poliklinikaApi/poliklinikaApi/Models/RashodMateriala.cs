using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class RashodMateriala
{
    public int IdRashodMateriala { get; set; }

    public int? IdProizvodstvo { get; set; }

    public int? IdMaterial { get; set; }

    public string? Rashod { get; set; }
}
