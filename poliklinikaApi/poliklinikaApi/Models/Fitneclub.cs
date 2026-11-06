using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Fitneclub
{
    public int IdFitnesclub { get; set; }

    public int? OpeningHour { get; set; }

    public int? CloseHour { get; set; }

    public int? RegistrationLimits { get; set; }
}
