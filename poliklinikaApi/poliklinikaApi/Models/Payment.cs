using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? FamilyMember { get; set; }

    public int? Good { get; set; }

    public int? Amount { get; set; }

    public DateTime? Date { get; set; }

    public virtual FamilyMember? FamilyMemberNavigation { get; set; }

    public virtual Good? GoodNavigation { get; set; }
}
