using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class Common2
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int ExamId { get; set; }

    public int ObtainedMarks { get; set; }
}
