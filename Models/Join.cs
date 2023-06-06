using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class Join
{
    public string StudentName { get; set; } = null!;

    public string CourseName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
