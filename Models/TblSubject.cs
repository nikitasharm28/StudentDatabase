using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblSubject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateAndTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<TblBook> TblBooks { get; } = new List<TblBook>();

    public virtual ICollection<TblCourseSubject> TblCourseSubjects { get; } = new List<TblCourseSubject>();

    public virtual ICollection<TblTeacherSubject> TblTeacherSubjects { get; } = new List<TblTeacherSubject>();
}
