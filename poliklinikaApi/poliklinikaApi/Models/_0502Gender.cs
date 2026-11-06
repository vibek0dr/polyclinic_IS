using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Gender
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<_0502Client> _0502Clients { get; set; } = new List<_0502Client>();
}
