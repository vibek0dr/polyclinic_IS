using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ClientMembership
{
    public int ClientMembershipId { get; set; }

    public int ClientId { get; set; }

    public int MembershipId { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public string Status { get; set; } = null!;

    public int? RemainingVisits { get; set; }

    public virtual Client2 Client { get; set; } = null!;

    public virtual Membership Membership { get; set; } = null!;
}
