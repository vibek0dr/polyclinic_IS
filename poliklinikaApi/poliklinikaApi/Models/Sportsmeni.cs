using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sportsmeni
{
    public int IdSportsmena { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public DateOnly DataRojdeniya { get; set; }

    public string? MestoRojdeniya { get; set; }

    public int? IdKlassivikacii { get; set; }

    public int? IdTrenirovki { get; set; }

    public int? IdSorevnovaniya { get; set; }

    public int? IdTitula { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRoli { get; set; }

    public virtual Klassifikaciya? IdKlassivikaciiNavigation { get; set; }

    public virtual Roli IdRoliNavigation { get; set; } = null!;

    public virtual Sorevnovaniya? IdSorevnovaniyaNavigation { get; set; }

    public virtual Titul? IdTitulaNavigation { get; set; }
}
