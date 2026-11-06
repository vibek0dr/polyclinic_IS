using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Film
{
    public int IdFilma { get; set; }

    public int? Janr { get; set; }

    public string? Nazvanie { get; set; }

    public int? Rejiser { get; set; }

    public virtual Janr? JanrNavigation { get; set; }

    public virtual Rejiseri? RejiserNavigation { get; set; }
}
