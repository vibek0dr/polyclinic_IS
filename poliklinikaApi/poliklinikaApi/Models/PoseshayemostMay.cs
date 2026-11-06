using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class PoseshayemostMay
{
    public int IdStudenta { get; set; }

    public int? UvajitelniyePropuski { get; set; }

    public int? NeuvajitelniyePropuski { get; set; }
}
