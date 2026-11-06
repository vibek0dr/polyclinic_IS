using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up05StUser
{
    public int Iduser { get; set; }

    public int Idrole { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
