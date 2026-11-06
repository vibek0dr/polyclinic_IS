using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpVrachi
{
    public int KodVracha { get; set; }

    public int KodPolzovatelya { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public int KodSpecializacii { get; set; }

    public string NomerKabineta { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public virtual KpPolzovateli KodPolzovatelyaNavigation { get; set; } = null!;

    public virtual KpSpecializacii KodSpecializaciiNavigation { get; set; } = null!;

    public virtual ICollection<KpRaspisanie> KpRaspisanies { get; set; } = new List<KpRaspisanie>();
}
