using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakaz
{
    public int IdZakaz { get; set; }

    public DateOnly? Data { get; set; }

    public string? Status { get; set; }
}
