using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Cost { get; set; }

    public string? Description { get; set; }

    public string? MainImagePath { get; set; }

    public bool IsActive { get; set; }

    public int? ManufacturerId { get; set; }

    public virtual _0502Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<_0502ProductPhoto> _0502ProductPhotos { get; set; } = new List<_0502ProductPhoto>();

    public virtual ICollection<_0502Product> AttachedProducts { get; set; } = new List<_0502Product>();

    public virtual ICollection<_0502Product> MainProducts { get; set; } = new List<_0502Product>();
}
