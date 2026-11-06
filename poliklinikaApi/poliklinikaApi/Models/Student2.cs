using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Student2
{
    public int IdStudent { get; set; }

    public string? Imya { get; set; }

    public string? Familiya { get; set; }

    public int? Kurs { get; set; }

    public virtual ICollection<Gruppa1> Gruppa1s { get; set; } = new List<Gruppa1>();
}
