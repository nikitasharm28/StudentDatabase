using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblStudentCourseSubject
{
    public int StudentCourseSubjectId { get; set; }

    public int EnrollmentId { get; set; }

    public int CourseSubjectId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourseSubject CourseSubject { get; set; } = null!;

    public virtual TblEnrollment Enrollment { get; set; } = null!;
}
