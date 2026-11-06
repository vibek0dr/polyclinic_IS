using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Tabel
{
    public int TabelId { get; set; }

    public int SotrudnikId { get; set; }

    public DateOnly Data { get; set; }

    public bool Yavka { get; set; }

    public int Chasov { get; set; }

    public string? Prichina { get; set; }

    public virtual _0302Sotrudniki Sotrudnik { get; set; } = null!;
}
