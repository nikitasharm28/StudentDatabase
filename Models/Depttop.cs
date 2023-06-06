using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class Depttop
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int Semester { get; set; }

    public int? HighestMarks { get; set; }
}
