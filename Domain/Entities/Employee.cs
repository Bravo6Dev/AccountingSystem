using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Employee
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Passowrd { get; set; } = null!;

    public decimal Salary { get; set; }

    public DateTime CreateDate { get; set; }

    public DataStatus Status { get; set; }

    public int PermissionId { get; set; }

    public virtual ICollection<CashBox> CashBoxes { get; set; } = new List<CashBox>();

    public virtual Permission Permission { get; set; } = null!;
}
