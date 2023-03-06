using System;
using System.Collections.Generic;

namespace Team_4.Models;

public partial class OrderItem
{
    public int ItemId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? ListPrice { get; set; }
}
