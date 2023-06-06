using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class Vwcourse
{
    public string CourseName { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public int ObtainedMarks { get; set; }

    public int ExamId { get; set; }

    public int DepartmentId { get; set; }
}
