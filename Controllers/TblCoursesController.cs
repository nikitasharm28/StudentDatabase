using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentDatabase.Models;

namespace StudentDatabase.Controllers
{
    public class TblCoursesController : Controller
    {
        private readonly StudentDatabaseContext _context;

        public TblCoursesController(StudentDatabaseContext context)
        {
            _context = context;
        }

        // GET: TblCourses
        public async Task<IActionResult> Index()
        {
            var studentDatabaseContext = _context.TblCourses.Include(t => t.Department);
            return View(await studentDatabaseContext.ToListAsync());
        }

        // GET: TblCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblCourses == null)
            {
                return NotFound();
            }

            var tblCourse = await _context.TblCourses
                .Include(t => t.Department)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (tblCourse == null)
            {
                return NotFound();
            }

            return View(tblCourse);
        }

        // GET: TblCourses/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.TblDepartments, "DepartmentId", "DepartmentId");
            return View();
        }

        // POST: TblCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,DepartmentId,CourseName,CourseFee,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblCourse tblCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.TblDepartments, "DepartmentId", "DepartmentId", tblCourse.DepartmentId);
            return View(tblCourse);
        }

        // GET: TblCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblCourses == null)
            {
                return NotFound();
            }

            var tblCourse = await _context.TblCourses.FindAsync(id);
            if (tblCourse == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.TblDepartments, "DepartmentId", "DepartmentId", tblCourse.DepartmentId);
            return View(tblCourse);
        }

        // POST: TblCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,DepartmentId,CourseName,CourseFee,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblCourse tblCourse)
        {
            if (id != tblCourse.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCourseExists(tblCourse.CourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.TblDepartments, "DepartmentId", "DepartmentId", tblCourse.DepartmentId);
            return View(tblCourse);
        }

        // GET: TblCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblCourses == null)
            {
                return NotFound();
            }

            var tblCourse = await _context.TblCourses
                .Include(t => t.Department)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (tblCourse == null)
            {
                return NotFound();
            }

            return View(tblCourse);
        }

        // POST: TblCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblCourses == null)
            {
                return Problem("Entity set 'StudentDatabaseContext.TblCourses'  is null.");
            }
            var tblCourse = await _context.TblCourses.FindAsync(id);
            if (tblCourse != null)
            {
                _context.TblCourses.Remove(tblCourse);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCourseExists(int id)
        {
          return _context.TblCourses.Any(e => e.CourseId == id);
        }
    }
}
