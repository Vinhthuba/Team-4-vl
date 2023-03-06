using System;
using System.Collections.Generic;

namespace Team_4.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? CategoryId { get; set; }

    public int? ModelYear { get; set; }

    public int? ListPrice { get; set; }

    public string? Description1 { get; set; }
}
