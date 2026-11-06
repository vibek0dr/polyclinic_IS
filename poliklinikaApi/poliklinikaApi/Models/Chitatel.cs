using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Chitatel
{
    public int IdChitatel { get; set; }

    public string? Fio { get; set; }

    public string? Adres { get; set; }

    public string? Phone { get; set; }

    public string? DataRojdeniya { get; set; }

    public virtual ICollection<ChitatelskiyBilet> ChitatelskiyBilets { get; set; } = new List<ChitatelskiyBilet>();
}
