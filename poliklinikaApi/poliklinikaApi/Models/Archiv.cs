using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Archiv
{
    public int IdArchiv { get; set; }

    public int? TrudovayaKnijka { get; set; }

    public virtual ICollection<OtdelKadrov> OtdelKadrovs { get; set; } = new List<OtdelKadrov>();

    public virtual TrudovayaKnijka? TrudovayaKnijkaNavigation { get; set; }
}
