using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class ViewEligibleStudentsForTopper
{
    public int StudentId { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int Semester { get; set; }

    public int CourseSemesterSubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int ObtainedMarks { get; set; }
}
