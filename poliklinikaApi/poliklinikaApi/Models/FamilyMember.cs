using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class FamilyMember
{
    public int MemberId { get; set; }

    public string? Status { get; set; }

    public string? MemberName { get; set; }

    public DateOnly? Birthday { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
