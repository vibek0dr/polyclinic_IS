using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Pokupatel
{
    public int IdPokupatelya { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }
}
