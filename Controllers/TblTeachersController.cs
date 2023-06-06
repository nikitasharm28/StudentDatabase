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
    public class TblTeachersController : Controller
    {
        private readonly StudentDatabaseContext _context;

        public TblTeachersController(StudentDatabaseContext context)
        {
            _context = context;
        }

        // GET: TblTeachers
        public async Task<IActionResult> Index()
        {
              return View(await _context.TblTeachers.ToListAsync());
        }

        // GET: TblTeachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblTeachers == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.TblTeachers
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (tblTeacher == null)
            {
                return NotFound();
            }

            return View(tblTeacher);
        }

        // GET: TblTeachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblTeachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,TeacherName,FatherName,MotherName,DateOfBirth,Gender,Email,PhoneNumber,EmergencyPhoneNumber,AddressLine1,AddressLine2,State,City,District,ZipCode,Qualification,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblTeacher tblTeacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblTeacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblTeacher);
        }

        // GET: TblTeachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblTeachers == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.TblTeachers.FindAsync(id);
            if (tblTeacher == null)
            {
                return NotFound();
            }
            return View(tblTeacher);
        }

        // POST: TblTeachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,TeacherName,FatherName,MotherName,DateOfBirth,Gender,Email,PhoneNumber,EmergencyPhoneNumber,AddressLine1,AddressLine2,State,City,District,ZipCode,Qualification,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,IsDeleted,DeleteDate")] TblTeacher tblTeacher)
        {
            if (id != tblTeacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblTeacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblTeacherExists(tblTeacher.TeacherId))
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
            return View(tblTeacher);
        }

        // GET: TblTeachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblTeachers == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.TblTeachers
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (tblTeacher == null)
            {
                return NotFound();
            }

            return View(tblTeacher);
        }

        // POST: TblTeachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblTeachers == null)
            {
                return Problem("Entity set 'StudentDatabaseContext.TblTeachers'  is null.");
            }
            var tblTeacher = await _context.TblTeachers.FindAsync(id);
            if (tblTeacher != null)
            {
                _context.TblTeachers.Remove(tblTeacher);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblTeacherExists(int id)
        {
          return _context.TblTeachers.Any(e => e.TeacherId == id);
        }
    }
}
