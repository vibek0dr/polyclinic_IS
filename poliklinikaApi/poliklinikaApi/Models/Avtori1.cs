using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Avtori1
{
    public int IdAvtor { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthYear { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Kniga1> Kniga1s { get; set; } = new List<Kniga1>();
}
