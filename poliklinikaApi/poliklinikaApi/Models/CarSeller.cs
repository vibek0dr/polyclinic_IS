using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class CarSeller
{
    public int IdCarSeller { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Patronymic { get; set; }

    public int? Passport { get; set; }

    public string? Phone { get; set; }

    public string? Adres { get; set; }
}
