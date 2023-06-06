using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblExam
{
    public int ExamId { get; set; }

    public int CourseSemesterSubjectId { get; set; }

    public DateTime ExamDate { get; set; }

    public int TotalMarks { get; set; }

    public int PassingMarks { get; set; }

    public double DurationOfExamInHour { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourseSemesterSubject CourseSemesterSubject { get; set; } = null!;

    public virtual ICollection<TblStudentExam> TblStudentExams { get; } = new List<TblStudentExam>();
}
