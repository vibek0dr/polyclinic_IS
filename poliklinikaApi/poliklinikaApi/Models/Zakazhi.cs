using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakazhi
{
    public string IdZakaza { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Inn { get; set; }

    public string? Addres { get; set; }

    public string? Phone { get; set; }

    public bool? Salesman { get; set; }

    public bool? Buyer { get; set; }
}
