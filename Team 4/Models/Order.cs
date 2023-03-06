using System;
using System.Collections.Generic;

namespace Team_4.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? StaffId { get; set; }
}
