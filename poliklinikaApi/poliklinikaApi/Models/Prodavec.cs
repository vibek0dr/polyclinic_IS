using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Prodavec
{
    public int IdProdavec { get; set; }

    public string? Fio { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Tovar2> Tovar2s { get; set; } = new List<Tovar2>();
}
