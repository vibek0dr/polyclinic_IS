using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ChitatelskiyBilet
{
    public int IdBileta { get; set; }

    public int? IdChitatelya { get; set; }

    public int? VidaniyiKnigi { get; set; }

    public virtual Chitatel? IdChitatelyaNavigation { get; set; }

    public virtual Ekzempkyar? VidaniyiKnigiNavigation { get; set; }
}
