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
    public class IndexModel : PageModel
    {
        private readonly TaskList.Models.TaskContext _context;

        public IndexModel(TaskList.Models.TaskContext context)
        {
            _context = context;
        }

        public IList<TaskList.Models.Task> Task { get;set; }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Task = await _context.Task.ToListAsync();
        }
    }
}
