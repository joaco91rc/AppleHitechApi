using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Documento { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public int? IdRol { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual Rol? IdRolNavigation { get; set; }
}
