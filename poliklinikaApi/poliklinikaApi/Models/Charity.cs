using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Charity
{
    public int CharityId { get; set; }

    public string CharityName { get; set; } = null!;

    public string? CharityDescription { get; set; }

    public string? CharityLogo { get; set; }

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
