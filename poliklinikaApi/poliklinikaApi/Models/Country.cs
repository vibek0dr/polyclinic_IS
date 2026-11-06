using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Country
{
    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string CountryFlag { get; set; } = null!;

    public virtual ICollection<Runner> Runners { get; set; } = new List<Runner>();

    public virtual ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
}
