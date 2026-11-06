using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Statuss
{
    public int IdStatus { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
