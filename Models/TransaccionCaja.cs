using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class TransaccionCaja
{
    public int IdTransaccion { get; set; }

    public int? IdCajaRegistradora { get; set; }

    public DateTime? Hora { get; set; }

    public string? TipoTransaccion { get; set; }

    public decimal? Monto { get; set; }

    public string? DocAsociado { get; set; }

    public string? UsuarioTransaccion { get; set; }

    public string? FormaPago { get; set; }

    public virtual CajaRegistradora? IdCajaRegistradoraNavigation { get; set; }
}
