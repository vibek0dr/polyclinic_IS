using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class VidTrenirovlki
{
    public int IdVidaTrenirovki { get; set; }

    public string? VidTrenirovki { get; set; }

    public virtual ICollection<Abonementi> Abonementis { get; set; } = new List<Abonementi>();
}
