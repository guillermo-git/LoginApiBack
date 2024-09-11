using System;
using System.Collections.Generic;

namespace SYSMEwebAPIback.Models;

public partial class MenuRol
{
    public int IdMenuRol { get; set; }

    public int IdMenu { get; set; }

    public string? IdRol { get; set; }

    public virtual Rol IdMenu1 { get; set; } = null!;

    public virtual Menu IdMenuNavigation { get; set; } = null!;
}
