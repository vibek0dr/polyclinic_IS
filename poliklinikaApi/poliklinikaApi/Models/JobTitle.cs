using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class JobTitle
{
    public int IdJobTitle { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Userstore> Userstores { get; set; } = new List<Userstore>();
}
