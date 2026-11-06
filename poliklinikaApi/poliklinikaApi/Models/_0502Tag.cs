using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Tag
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Color { get; set; } = null!;

    public virtual ICollection<_0502Client> Clients { get; set; } = new List<_0502Client>();
}
