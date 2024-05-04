using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class CajaRegistradora
{
    public int IdCajaRegistradora { get; set; }

    public DateTime? FechaApertura { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? UsuarioAperturacaja { get; set; }

    public decimal? Saldo { get; set; }

    public bool? Estado { get; set; }

    public decimal? SaldoMp { get; set; }

    public decimal? SaldoUss { get; set; }

    public decimal? SaldoGalicia { get; set; }

    public virtual ICollection<TransaccionCaja> TransaccionCajas { get; } = new List<TransaccionCaja>();
}
