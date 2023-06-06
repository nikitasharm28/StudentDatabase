using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblStudentExam
{
    public int StudentExamId { get; set; }

    public int ExamId { get; set; }

    public int EnrollmentId { get; set; }

    public int ObtainedMarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual TblEnrollment Enrollment { get; set; } = null!;

    public virtual TblExam Exam { get; set; } = null!;
}
