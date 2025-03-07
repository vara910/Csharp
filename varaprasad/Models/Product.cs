using System;
using System.Collections.Generic;

namespace VaraPrasad.Models;

public partial class Product
{
    public int Id { get; set; }

    public int Price { get; set; }

    public string Name { get; set; } = null!;
}
