using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GithubLabelMl.Models;

namespace GithubLabelMl.Controllers
{
    public class GitpredsController : Controller
    {
        private readonly GithubLabelMlContext _context;

        public GitpredsController(GithubLabelMlContext context)
        {
            _context = context;
        }

        // GET: Gitpreds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gitpred.ToListAsync());
        }

        // GET: Gitpreds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gitpred = await _context.Gitpred
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gitpred == null)
            {
                return NotFound();
            }

            return View(gitpred);
        }

        // GET: Gitpreds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gitpreds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Area")] Gitpred gitpred)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gitpred);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gitpred);
        }

        // GET: Gitpreds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gitpred = await _context.Gitpred.FindAsync(id);
            if (gitpred == null)
            {
                return NotFound();
            }
            return View(gitpred);
        }

        // POST: Gitpreds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Area")] Gitpred gitpred)
        {
            if (id != gitpred.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gitpred);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GitpredExists(gitpred.Id))
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
            return View(gitpred);
        }

        // GET: Gitpreds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gitpred = await _context.Gitpred
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gitpred == null)
            {
                return NotFound();
            }

            return View(gitpred);
        }

        // POST: Gitpreds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gitpred = await _context.Gitpred.FindAsync(id);
            _context.Gitpred.Remove(gitpred);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GitpredExists(int id)
        {
            return _context.Gitpred.Any(e => e.Id == id);
        }
    }
}
