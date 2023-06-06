using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class Abc
{
    public string StudentName { get; set; } = null!;

    public int? Totalmarks { get; set; }

    public string CourseName { get; set; } = null!;
}
