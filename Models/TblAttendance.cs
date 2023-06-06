using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblAttendance
{
    public int AttendanceId { get; set; }

    public int? EnrollmentId { get; set; }

    public int? CourseSemesterSubjectId { get; set; }

    public DateTime? Date { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual TblCourseSemesterSubject? CourseSemesterSubject { get; set; }

    public virtual TblEnrollment? Enrollment { get; set; }
}
