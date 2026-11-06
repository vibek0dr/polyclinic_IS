using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sotrudnik
{
    public int IdSotrudnik { get; set; }

    public string? Fio { get; set; }

    public string? Telephone { get; set; }

    public string? DataRojdeniya { get; set; }

    public virtual ICollection<TrudovayaKnijka> TrudovayaKnijkas { get; set; } = new List<TrudovayaKnijka>();
}
