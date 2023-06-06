using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblBorrowedBook
{
    public int BorrowedBookId { get; set; }

    public int BookId { get; set; }

    public int BorrowerId { get; set; }

    public DateTime DateBorrowed { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? DateReturned { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblBook Book { get; set; } = null!;

    public virtual TblBorrower Borrower { get; set; } = null!;
}
