using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblCourseSemester
{
    public int CourseSemesterId { get; set; }

    public int CourseId { get; set; }

    public int Semester { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual ICollection<TblCourseSemesterSubject> TblCourseSemesterSubjects { get; } = new List<TblCourseSemesterSubject>();
}
