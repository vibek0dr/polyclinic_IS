using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Userr
{
    public string? Imya { get; set; }

    public string? Familiya { get; set; }

    public string Otchestvo { get; set; } = null!;

    public DateOnly? DataRojdeniya { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? IdRole { get; set; }
}
