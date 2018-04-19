using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TaskList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TaskContext(
                serviceProvider.GetRequiredService<DbContextOptions<TaskContext>>()))
                {
                   if (context.Task.Any())
                   {
                       return;
                   }

                   context.Task.AddRange(
                       new Task
                       {
                           TaskDescription = "Complete Taxes",
                           DueDate = DateTime.Parse("2018-04-30"),
                           Priority = "Not Critical"
                       },

                       new Task
                       {
                           TaskDescription = "Pay the Power Bill",
                           DueDate = DateTime.Parse("2018-04-13"),
                           Priority = "Urgent"
                       },

                       new Task
                       {
                           TaskDescription = "Wash the Jeep",
                           DueDate = DateTime.Parse("2018-04-28"),
                           Priority = "Critical"
                       },

                       new Task
                       {
                           TaskDescription = "Take the Trash Out",
                           DueDate = DateTime.Parse("2018-05-25"),
                           Priority = "Not Critical"
                       }
                   );
                   context.SaveChanges();
                }
            }
        }
    }
