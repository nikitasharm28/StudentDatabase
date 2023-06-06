using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class VwTopperDepartment
{
    public string StudentName { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public int? HighestScore { get; set; }
}
