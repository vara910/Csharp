using System;
using System.Collections.Generic;

namespace VaraPrasad.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Addr { get; set; } = null!;
}
