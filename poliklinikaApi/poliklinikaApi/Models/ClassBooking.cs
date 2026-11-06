using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ClassBooking
{
    public int BookingId { get; set; }

    public int ClientId { get; set; }

    public int ClassId { get; set; }

    public DateTime BookingDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual GroupClass Class { get; set; } = null!;

    public virtual Client2 Client { get; set; } = null!;
}
