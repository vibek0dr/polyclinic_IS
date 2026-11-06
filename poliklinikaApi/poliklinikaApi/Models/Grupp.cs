using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Grupp
{
    public int IdGrupps { get; set; }

    public string Nazvanie { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
