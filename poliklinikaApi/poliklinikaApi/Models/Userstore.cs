using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Userstore
{
    public int IdUser { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly BirthDate { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public int? JobTitle { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual JobTitle? JobTitleNavigation { get; set; }

    public virtual ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
}
