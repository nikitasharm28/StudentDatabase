using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblCourse
{
    public int CourseId { get; set; }

    public int DepartmentId { get; set; }

    public string CourseName { get; set; } = null!;

    public decimal? CourseFee { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblDepartment Department { get; set; } = null!;

    public virtual ICollection<TblCourseSemester> TblCourseSemesters { get; } = new List<TblCourseSemester>();

    public virtual ICollection<TblCourseSubject> TblCourseSubjects { get; } = new List<TblCourseSubject>();

    public virtual ICollection<TblEnrollment> TblEnrollments { get; } = new List<TblEnrollment>();
}
