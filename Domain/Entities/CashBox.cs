using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CashBox
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Balance { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DataStatus Status { get; set; }

    public virtual Employee? Employee { get; set; }
}
