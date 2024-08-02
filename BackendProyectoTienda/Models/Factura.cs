﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BackendProyectoTienda.Models;

public partial class Factura
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public int? EmpresaId { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente Cliente { get; set; }

    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();

    public virtual Empresa Empresa { get; set; }
}