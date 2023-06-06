using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Models;

public partial class StudentDatabaseContext : DbContext
{
    public StudentDatabaseContext()
    {
    }

    public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abc> Abcs { get; set; }

    public virtual DbSet<Common> Commons { get; set; }

    public virtual DbSet<Common1> Common1s { get; set; }

    public virtual DbSet<Common2> Common2s { get; set; }

    public virtual DbSet<Depttop> Depttops { get; set; }

    public virtual DbSet<Join> Joins { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblBorrowedBook> TblBorrowedBooks { get; set; }

    public virtual DbSet<TblBorrower> TblBorrowers { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblCourseSemester> TblCourseSemesters { get; set; }

    public virtual DbSet<TblCourseSemesterSubject> TblCourseSemesterSubjects { get; set; }

    public virtual DbSet<TblCourseSubject> TblCourseSubjects { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblEnrollment> TblEnrollments { get; set; }

    public virtual DbSet<TblExam> TblExams { get; set; }

    public virtual DbSet<TblLibrarian> TblLibrarians { get; set; }

    public virtual DbSet<TblLibrary> TblLibraries { get; set; }

    public virtual DbSet<TblLibrarySection> TblLibrarySections { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    public virtual DbSet<TblStudentCourseSubject> TblStudentCourseSubjects { get; set; }

    public virtual DbSet<TblStudentExam> TblStudentExams { get; set; }

    public virtual DbSet<TblSubject> TblSubjects { get; set; }

    public virtual DbSet<TblTeacher> TblTeachers { get; set; }

    public virtual DbSet<TblTeacherSubject> TblTeacherSubjects { get; set; }

    public virtual DbSet<ViewCourseSemSub> ViewCourseSemSubs { get; set; }

    public virtual DbSet<ViewEligibleStudentsForTopper> ViewEligibleStudentsForToppers { get; set; }

    public virtual DbSet<VwCourseSemSub> VwCourseSemSubs { get; set; }

    public virtual DbSet<VwCourseTopper> VwCourseToppers { get; set; }

    public virtual DbSet<VwTopperDepartment> VwTopperDepartments { get; set; }

    public virtual DbSet<Vwcourse> Vwcourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-5432CBB\\SQLEXPRESS; database=StudentDatabase; trusted_connection=true; trustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("abc");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Common>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("common");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Common1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("common1");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Common2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("common2");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Depttop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DEPTTOP");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Join>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("joins");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__tblAtten__8B69261C60B967CE");

            entity.ToTable("tblAttendance");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CourseSemesterSubject).WithMany(p => p.TblAttendances)
                .HasForeignKey(d => d.CourseSemesterSubjectId)
                .HasConstraintName("FK__tblAttend__Cours__3864608B");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblAttendances)
                .HasForeignKey(d => d.EnrollmentId)
                .HasConstraintName("FK_tblAttendance_tblEnrollment");
        });

        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__tblBook__3DE0C2072B47C8A0");

            entity.ToTable("tblBook");

            entity.Property(e => e.BookAuthor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BookDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BookPublisher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BookTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblBooks)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblBook__Subject__55009F39");
        });

        modelBuilder.Entity<TblBorrowedBook>(entity =>
        {
            entity.HasKey(e => e.BorrowedBookId).HasName("PK__tblBorro__53B3FBE8DFE9FEAA");

            entity.ToTable("tblBorrowedBook");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateBorrowed).HasColumnType("date");
            entity.Property(e => e.DateReturned).HasColumnType("date");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Book).WithMany(p => p.TblBorrowedBooks)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblBorrow__BookI__6166761E");

            entity.HasOne(d => d.Borrower).WithMany(p => p.TblBorrowedBooks)
                .HasForeignKey(d => d.BorrowerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblBorrow__Borro__625A9A57");
        });

        modelBuilder.Entity<TblBorrower>(entity =>
        {
            entity.HasKey(e => e.BorrowerId).HasName("PK__tblBorro__568EDB5749627576");

            entity.ToTable("tblBorrower");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Student).WithMany(p => p.TblBorrowers)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblBorrow__Stude__5E8A0973");
        });

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__tblCours__C92D71A733299739");

            entity.ToTable("tblCourse");

            entity.Property(e => e.CourseFee).HasColumnType("money");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Department).WithMany(p => p.TblCourses)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Depar__2645B050");
        });

        modelBuilder.Entity<TblCourseSemester>(entity =>
        {
            entity.HasKey(e => e.CourseSemesterId).HasName("PK__tblCours__F79CCA616D49CBBD");

            entity.ToTable("tblCourseSemester");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.TblCourseSemesters)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Cours__29221CFB");
        });

        modelBuilder.Entity<TblCourseSemesterSubject>(entity =>
        {
            entity.HasKey(e => e.CourseSemesterSubjectId).HasName("PK__tblCours__62B7CBAE5BE8FE20");

            entity.ToTable("tblCourseSemesterSubject");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CourseSemester).WithMany(p => p.TblCourseSemesterSubjects)
                .HasForeignKey(d => d.CourseSemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Cours__3D2915A8");

            entity.HasOne(d => d.CourseSubject).WithMany(p => p.TblCourseSemesterSubjects)
                .HasForeignKey(d => d.CourseSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Cours__3E1D39E1");

            entity.HasOne(d => d.TeacherSubject).WithMany(p => p.TblCourseSemesterSubjects)
                .HasForeignKey(d => d.TeacherSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Teach__3F115E1A");
        });

        modelBuilder.Entity<TblCourseSubject>(entity =>
        {
            entity.HasKey(e => e.CourseSubjectId).HasName("PK__tblCours__8E8409760FECCCFB");

            entity.ToTable("tblCourseSubject");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.TblCourseSubjects)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Cours__2BFE89A6");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblCourseSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCourse__Subje__2CF2ADDF");
        });

        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__tblDepar__B2079BED0C7CA522");

            entity.ToTable("tblDepartment");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.HeadOfDepartmentNavigation).WithMany(p => p.TblDepartments)
                .HasForeignKey(d => d.HeadOfDepartment)
                .HasConstraintName("FK_tblDepartment_tblTeacher");
        });

        modelBuilder.Entity<TblEnrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__tblEnrol__7F68771B26CF3ADE");

            entity.ToTable("tblEnrollment");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentDate).HasColumnType("date");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.TblEnrollments)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblEnroll__Cours__3587F3E0");

            entity.HasOne(d => d.Student).WithMany(p => p.TblEnrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblEnroll__Stude__3493CFA7");
        });

        modelBuilder.Entity<TblExam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__tblExam__297521C70F674A6A");

            entity.ToTable("tblExam");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("date");
            entity.Property(e => e.DurationOfExamInHour)
                .HasDefaultValueSql("((3))")
                .HasColumnName("DurationOfExam(inHour)");
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.PassingMarks).HasDefaultValueSql("((33))");
            entity.Property(e => e.TotalMarks).HasDefaultValueSql("((100))");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CourseSemesterSubject).WithMany(p => p.TblExams)
                .HasForeignKey(d => d.CourseSemesterSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblExam__CourseS__06ED0088");
        });

        modelBuilder.Entity<TblLibrarian>(entity =>
        {
            entity.HasKey(e => e.LibrarianId).HasName("PK__tblLibra__E4D86D7D85EE3F58");

            entity.ToTable("tblLibrarian");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblLibrarians)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblLibrar__Teach__5224328E");
        });

        modelBuilder.Entity<TblLibrary>(entity =>
        {
            entity.HasKey(e => e.LibraryId).HasName("PK__tblLibra__A136475FB8AEC038");

            entity.ToTable("tblLibrary");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Book).WithMany(p => p.TblLibraries)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibrary_tblBook");

            entity.HasOne(d => d.Librarian).WithMany(p => p.TblLibraries)
                .HasForeignKey(d => d.LibrarianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblLibrar__Libra__5AB9788F");

            entity.HasOne(d => d.LibrarySection).WithMany(p => p.TblLibraries)
                .HasForeignKey(d => d.LibrarySectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblLibrar__Subje__5BAD9CC8");
        });

        modelBuilder.Entity<TblLibrarySection>(entity =>
        {
            entity.HasKey(e => e.LibrarySectionId).HasName("PK__tblSubje__660A21C256AE3EC5");

            entity.ToTable("tblLibrarySection");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.LibrarySectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__tblStude__32C52B995F150103");

            entity.ToTable("tblStudent");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.District)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblStudentCourseSubject>(entity =>
        {
            entity.HasKey(e => e.StudentCourseSubjectId).HasName("PK__tblStude__21F00FBEA463BA6D");

            entity.ToTable("tblStudentCourseSubject");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CourseSubject).WithMany(p => p.TblStudentCourseSubjects)
                .HasForeignKey(d => d.CourseSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblStuden__Cours__395884C4");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblStudentCourseSubjects)
                .HasForeignKey(d => d.EnrollmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblStuden__Enrol__3864608B");
        });

        modelBuilder.Entity<TblStudentExam>(entity =>
        {
            entity.HasKey(e => e.StudentExamId).HasName("PK__tblStude__C57949768E78287A");

            entity.ToTable("tblStudentExam");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblStudentExams)
                .HasForeignKey(d => d.EnrollmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblStuden__Enrol__162F4418");

            entity.HasOne(d => d.Exam).WithMany(p => p.TblStudentExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblStuden__ExamI__153B1FDF");
        });

        modelBuilder.Entity<TblSubject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__tblSubje__AC1BA3A8EA435F75");

            entity.ToTable("tblSubject");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTeacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__tblTeach__EDF259641E4B6191");

            entity.ToTable("tblTeacher");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.District)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Qualification)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TeacherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTeacherSubject>(entity =>
        {
            entity.HasKey(e => e.TeacherSubjectId).HasName("PK__tblTeach__FB4DA446445E7125");

            entity.ToTable("tblTeacherSubject");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblTeacherSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblTeache__Subje__2180FB33");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblTeacherSubjects)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblTeache__Teach__208CD6FA");
        });

        modelBuilder.Entity<ViewCourseSemSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewCourseSemSub");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEligibleStudentsForTopper>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewEligibleStudentsForTopper");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubjectName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCourseSemSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CourseSemSub");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCourseTopper>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCourseToppers");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTopperDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_topperDepartment");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vwcourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwcourse");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
