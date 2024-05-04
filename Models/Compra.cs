using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdProveedor { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NroDocumento { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public decimal? CotizacionDolar { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; } = new List<DetalleCompra>();

    public virtual Proveedor? IdProveedorNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
