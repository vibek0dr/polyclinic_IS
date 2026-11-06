using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Client2
{
    public int ClientId { get; set; }

    public int UserId { get; set; }

    public DateOnly? BirthDate { get; set; }

    public DateOnly RegistrationDate { get; set; }

    public virtual ICollection<ClassBooking> ClassBookings { get; set; } = new List<ClassBooking>();

    public virtual ICollection<ClientMembership> ClientMemberships { get; set; } = new List<ClientMembership>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual User2 User { get; set; } = null!;

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
