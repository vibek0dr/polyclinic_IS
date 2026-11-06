using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Izbrannoe
{
    public int? IdUser { get; set; }

    public int? IdGoroskop { get; set; }

    public virtual Goroskop? IdGoroskopNavigation { get; set; }

    public virtual _1809User? IdUserNavigation { get; set; }
}
