using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StProduct
{
    public string ProductArticleNumber { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public string ProductCategory { get; set; } = null!;

    public string? ProductPhoto { get; set; }

    public string ProductManufacturer { get; set; } = null!;

    public decimal ProductCost { get; set; }

    public byte? ProductDiscountAmount { get; set; }

    public int ProductQuantityInStock { get; set; }

    public string ProductStatus { get; set; } = null!;

    public virtual ICollection<Mdk0502StOrderProduct> Mdk0502StOrderProducts { get; set; } = new List<Mdk0502StOrderProduct>();
}
