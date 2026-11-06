using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Ocenki
{
    public int IdPredmeta { get; set; }

    public int IdStudenta { get; set; }

    public string Ocenka { get; set; } = null!;

    public virtual Predmeti IdPredmetaNavigation { get; set; } = null!;

    public virtual Studenti IdStudentaNavigation { get; set; } = null!;
}
