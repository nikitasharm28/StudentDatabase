using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblTeacher
{
    public int TeacherId { get; set; }

    public string TeacherName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? EmergencyPhoneNumber { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string District { get; set; } = null!;

    public int ZipCode { get; set; }

    public string Qualification { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<TblDepartment> TblDepartments { get; } = new List<TblDepartment>();

    public virtual ICollection<TblLibrarian> TblLibrarians { get; } = new List<TblLibrarian>();

    public virtual ICollection<TblTeacherSubject> TblTeacherSubjects { get; } = new List<TblTeacherSubject>();
}
