using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int? IdUsuario { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NroDocumento { get; set; }

    public string? DocumentoCliente { get; set; }

    public string? NombreCliente { get; set; }

    public decimal? MontoPago { get; set; }

    public decimal? MontoCambio { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? FormaPago { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? MontoDescuento { get; set; }

    public decimal? CotizacionDolar { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();
}
