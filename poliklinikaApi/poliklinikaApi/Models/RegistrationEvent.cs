using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class RegistrationEvent
{
    public int RegistrationEventId { get; set; }

    public int RegistrationId { get; set; }

    public string EventId { get; set; } = null!;

    public short? BibNumber { get; set; }

    public int? RaceTime { get; set; }

    public virtual Registration Registration { get; set; } = null!;
}
