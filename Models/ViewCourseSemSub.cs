using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class ViewCourseSemSub
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int Semester { get; set; }

    public int CourseSemesterId { get; set; }

    public int CourseSubjectId { get; set; }

    public int CourseSemesterSubjectId { get; set; }
}
