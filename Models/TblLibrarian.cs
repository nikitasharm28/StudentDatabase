using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblLibrarian
{
    public int LibrarianId { get; set; }

    public int TeacherId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<TblLibrary> TblLibraries { get; } = new List<TblLibrary>();

    public virtual TblTeacher Teacher { get; set; } = null!;
}
