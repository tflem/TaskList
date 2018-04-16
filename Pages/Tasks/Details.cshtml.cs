using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskList.Models;

namespace TaskList.Pages.Tasks
{
    public class DetailsModel : PageModel
    {
        private readonly TaskList.Models.TaskContext _context;

        public DetailsModel(TaskList.Models.TaskContext context)
        {
            _context = context;
        }

        public TaskList.Models.Task Task { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Task = await _context.Task.SingleOrDefaultAsync(m => m.ID == id);

            if (Task == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
