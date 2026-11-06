using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Zakaz
{
    public int IdZakaza { get; set; }

    public DateOnly Data { get; set; }

    public int IdZakazchika { get; set; }

    public int IdIspolnitel { get; set; }
}
