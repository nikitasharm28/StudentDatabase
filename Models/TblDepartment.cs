using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblDepartment
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? HeadOfDepartment { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblTeacher? HeadOfDepartmentNavigation { get; set; }

    public virtual ICollection<TblCourse> TblCourses { get; } = new List<TblCourse>();
}
