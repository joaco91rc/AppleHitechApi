using System;
using System.Collections.Generic;

namespace AppleHitechStoreApi.Models;

public partial class Negocio
{
    public int IdNegocio { get; set; }

    public string? Nombre { get; set; }

    public string? Cuit { get; set; }

    public string? Direccion { get; set; }

    public byte[]? Logo { get; set; }
}
