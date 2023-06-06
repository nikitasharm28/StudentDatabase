using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblCourseSemesterSubject
{
    public int CourseSemesterSubjectId { get; set; }

    public int CourseSemesterId { get; set; }

    public int CourseSubjectId { get; set; }

    public int TeacherSubjectId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourseSemester CourseSemester { get; set; } = null!;

    public virtual TblCourseSubject CourseSubject { get; set; } = null!;

    public virtual ICollection<TblAttendance> TblAttendances { get; } = new List<TblAttendance>();

    public virtual ICollection<TblExam> TblExams { get; } = new List<TblExam>();

    public virtual TblTeacherSubject TeacherSubject { get; set; } = null!;
}
