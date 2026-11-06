using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sorevnovaniya
{
    public int IdSorevnovaniya { get; set; }

    public string NazvanieSorevnovaniya { get; set; } = null!;

    public DateOnly Data { get; set; }

    public int IdUprajneniya { get; set; }

    public virtual Uprajneniya IdUprajneniyaNavigation { get; set; } = null!;

    public virtual ICollection<Sportsmeni> Sportsmenis { get; set; } = new List<Sportsmeni>();
}
