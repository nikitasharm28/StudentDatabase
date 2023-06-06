using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblEnrollment
{
    public int EnrollmentId { get; set; }

    public int CourseId { get; set; }

    public int StudentId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;

    public virtual ICollection<TblAttendance> TblAttendances { get; } = new List<TblAttendance>();

    public virtual ICollection<TblStudentCourseSubject> TblStudentCourseSubjects { get; } = new List<TblStudentCourseSubject>();

    public virtual ICollection<TblStudentExam> TblStudentExams { get; } = new List<TblStudentExam>();
}
