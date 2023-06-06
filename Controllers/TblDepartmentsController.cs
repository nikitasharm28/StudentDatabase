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
    public class TblDepartmentsController : Controller
    {
        private readonly StudentDatabaseContext _context;

        public TblDepartmentsController(StudentDatabaseContext context)
        {
            _context = context;
        }

        // GET: TblDepartments
        public async Task<IActionResult> Index()
        {
            var studentDatabaseContext = _context.TblDepartments.Include(t => t.HeadOfDepartmentNavigation);
            return View(await studentDatabaseContext.ToListAsync());
        }

        // GET: TblDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblDepartments == null)
            {
                return NotFound();
            }

            var tblDepartment = await _context.TblDepartments
                .Include(t => t.HeadOfDepartmentNavigation)
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (tblDepartment == null)
            {
                return NotFound();
            }

            return View(tblDepartment);
        }

        // GET: TblDepartments/Create
        public IActionResult Create()
        {
            ViewData["HeadOfDepartment"] = new SelectList(_context.TblTeachers, "TeacherId", "TeacherId");
            return View();
        }

        // POST: TblDepartments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepartmentId,DepartmentName,HeadOfDepartment,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblDepartment tblDepartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeadOfDepartment"] = new SelectList(_context.TblTeachers, "TeacherId", "TeacherId", tblDepartment.HeadOfDepartment);
            return View(tblDepartment);
        }

        // GET: TblDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblDepartments == null)
            {
                return NotFound();
            }

            var tblDepartment = await _context.TblDepartments.FindAsync(id);
            if (tblDepartment == null)
            {
                return NotFound();
            }
            ViewData["HeadOfDepartment"] = new SelectList(_context.TblTeachers, "TeacherId", "TeacherId", tblDepartment.HeadOfDepartment);
            return View(tblDepartment);
        }

        // POST: TblDepartments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepartmentId,DepartmentName,HeadOfDepartment,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblDepartment tblDepartment)
        {
            if (id != tblDepartment.DepartmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblDepartmentExists(tblDepartment.DepartmentId))
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
            ViewData["HeadOfDepartment"] = new SelectList(_context.TblTeachers, "TeacherId", "TeacherId", tblDepartment.HeadOfDepartment);
            return View(tblDepartment);
        }

        // GET: TblDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblDepartments == null)
            {
                return NotFound();
            }

            var tblDepartment = await _context.TblDepartments
                .Include(t => t.HeadOfDepartmentNavigation)
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (tblDepartment == null)
            {
                return NotFound();
            }

            return View(tblDepartment);
        }

        // POST: TblDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblDepartments == null)
            {
                return Problem("Entity set 'StudentDatabaseContext.TblDepartments'  is null.");
            }
            var tblDepartment = await _context.TblDepartments.FindAsync(id);
            if (tblDepartment != null)
            {
                _context.TblDepartments.Remove(tblDepartment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblDepartmentExists(int id)
        {
          return _context.TblDepartments.Any(e => e.DepartmentId == id);
        }
    }
}
