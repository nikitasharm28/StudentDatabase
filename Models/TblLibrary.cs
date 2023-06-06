using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblLibrary
{
    public int LibraryId { get; set; }

    public int LibrarianId { get; set; }

    public int LibrarySectionId { get; set; }

    public int BookId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblBook Book { get; set; } = null!;

    public virtual TblLibrarian Librarian { get; set; } = null!;

    public virtual TblLibrarySection LibrarySection { get; set; } = null!;
}
