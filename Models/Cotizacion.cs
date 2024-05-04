using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class Cotizacion
{
    public int IdCotizacion { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Estado { get; set; }
}
