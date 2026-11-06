using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Studenti
{
    public int IdStudenta { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public DateOnly Datas { get; set; }

    public string Pol { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public string Dom { get; set; } = null!;

    public string Kvartira { get; set; } = null!;

    public string GruppaZdorovya { get; set; } = null!;

    public string? Uvlecheniya { get; set; }

    public string? Telephone { get; set; }

    public int? Kurs { get; set; }
}
