using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class User2
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public int? IsBlocked { get; set; }

    public virtual ICollection<Client2> Client2s { get; set; } = new List<Client2>();

    public virtual ICollection<Employees2> Employees2s { get; set; } = new List<Employees2>();

    public virtual Role2 Role { get; set; } = null!;
}
