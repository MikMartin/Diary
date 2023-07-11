using Diary.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Diary.Data
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions options)
                  : base(options)
        {
        }
        public virtual DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AddTestingData(modelBuilder);
        }
       
        private void AddTestingData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note
                {
                    NoteId = 1,
                    NoteName = "Porada",
                    NoteDescription = "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                    NoteDate = new DateTime(2023, 8, 12)

                },
                new Note
                {
                    NoteId = 2,
                    NoteName = "uzávěrka",
                    NoteDescription = "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                    NoteDate = new DateTime(2023, 7, 11),

                },
                new Note
                {
                    NoteId = 3,
                    NoteName = "Porada",
                    NoteDescription = "Maecenas lorem. Fusce tellus. Pellentesque sapien. Nullam rhoncus aliquam metus. Cras elementum. In rutrum. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                    NoteDate = new DateTime(1923, 6, 8)

                });
        }
    }
}
