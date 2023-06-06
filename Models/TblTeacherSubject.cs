using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblTeacherSubject
{
    public int TeacherSubjectId { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblSubject Subject { get; set; } = null!;

    public virtual ICollection<TblCourseSemesterSubject> TblCourseSemesterSubjects { get; } = new List<TblCourseSemesterSubject>();

    public virtual TblTeacher Teacher { get; set; } = null!;
}
