﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmlpoyeeCrudApp.Models;

namespace EmlpoyeeCrudApp.Controllers
{
    public class EmployeeViewModelsController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeViewModelsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: EmployeeViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeViewModel.ToListAsync());
        }

        // GET: EmployeeViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }

            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,EmployeeNum,EmployeeDate,TerminatedDate,PersonId,FirstName,LastName,BirthDate")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel.FindAsync(id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }
            return View(employeeViewModel);
        }

        // POST: EmployeeViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,EmployeeNum,EmployeeDate,TerminatedDate,PersonId,FirstName,LastName,BirthDate")] EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeViewModelExists(employeeViewModel.EmployeeId))
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
            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }

            return View(employeeViewModel);
        }

        // POST: EmployeeViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeViewModel = await _context.EmployeeViewModel.FindAsync(id);
            _context.EmployeeViewModel.Remove(employeeViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeViewModelExists(int id)
        {
            return _context.EmployeeViewModel.Any(e => e.EmployeeId == id);
        }
    }
}
