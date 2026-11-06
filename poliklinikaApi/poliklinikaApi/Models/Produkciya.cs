using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Produkciya
{
    public int IdProdukciya { get; set; }

    public string Naimenovanie { get; set; } = null!;

    public string EdIzmereniya { get; set; } = null!;

    public int Cena { get; set; }
}
