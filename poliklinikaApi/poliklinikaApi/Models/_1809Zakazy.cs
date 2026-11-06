using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Zakazy
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int? DriverId { get; set; }

    public int? TruckId { get; set; }

    public string AdresOtkuda { get; set; } = null!;

    public string AdresKuda { get; set; } = null!;

    public string NazvanieGruza { get; set; } = null!;

    public decimal Ves { get; set; }

    public decimal Tsena { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Sozdan { get; set; }

    public DateTime? Dostavlen { get; set; }

    public virtual _1809User1 Client { get; set; } = null!;

    public virtual _1809Voditeli? Driver { get; set; }

    public virtual _1809Gruzoviki1? Truck { get; set; }

    public virtual ICollection<_1809IstoriyaStatusov> _1809IstoriyaStatusovs { get; set; } = new List<_1809IstoriyaStatusov>();
}
