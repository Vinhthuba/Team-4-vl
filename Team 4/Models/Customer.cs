using System;
using System.Collections.Generic;

namespace Team_4.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }
}
