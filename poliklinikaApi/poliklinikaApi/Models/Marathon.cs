using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Marathon
{
    public byte MarathonId { get; set; }

    public string MarathonName { get; set; } = null!;

    public string? CityName { get; set; }

    public string CountryCode { get; set; } = null!;

    public short? YearHeld { get; set; }
}
