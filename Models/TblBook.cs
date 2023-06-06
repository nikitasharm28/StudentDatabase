using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblBook
{
    public int BookId { get; set; }

    public int SubjectId { get; set; }

    public string BookTitle { get; set; } = null!;

    public string BookAuthor { get; set; } = null!;

    public string? BookDescription { get; set; }

    public string BookPublisher { get; set; } = null!;

    public int NumberOfPages { get; set; }

    public int NumberOfBookCopies { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDateAndTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblSubject Subject { get; set; } = null!;

    public virtual ICollection<TblBorrowedBook> TblBorrowedBooks { get; } = new List<TblBorrowedBook>();

    public virtual ICollection<TblLibrary> TblLibraries { get; } = new List<TblLibrary>();
}
