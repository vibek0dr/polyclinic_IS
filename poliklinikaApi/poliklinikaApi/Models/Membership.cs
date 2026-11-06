using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Membership
{
    public int MembershipId { get; set; }

    public string Name { get; set; } = null!;

    public int DurationDays { get; set; }

    public int? MaxVisits { get; set; }

    public int PriceRub { get; set; }

    public virtual ICollection<ClientMembership> ClientMemberships { get; set; } = new List<ClientMembership>();
}
