using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class PoseshayemostMart
{
    public int IdStudenta { get; set; }

    public int? UvajitelniyePropuski { get; set; }

    public int? NeuvajitelniyePropuski { get; set; }
}
