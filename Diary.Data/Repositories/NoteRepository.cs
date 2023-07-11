using Diary.Data.Interfaces;
using Diary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Repositories
{
    public class NoteRepository : BaseRepository<Note>, INoteRepository
    {
        public NoteRepository(NoteDbContext noteDbContext) : base(noteDbContext)
        {
        }

    }
}
