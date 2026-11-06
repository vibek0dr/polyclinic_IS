using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class RegistrationStatus
{
    public byte RegistrationStatusId { get; set; }

    public string RegistrationStatus1 { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
