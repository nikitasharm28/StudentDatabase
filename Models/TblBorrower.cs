using System;
using System.Collections.Generic;

namespace StudentDatabase.Models;

public partial class TblBorrower
{
    public int BorrowerId { get; set; }

    public int StudentId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblStudent Student { get; set; } = null!;

    public virtual ICollection<TblBorrowedBook> TblBorrowedBooks { get; } = new List<TblBorrowedBook>();
}
