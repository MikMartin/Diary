using Diary.Api.Interfaces;
using Diary.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteManager noteManager;
        
        public NotesController(INoteManager noteManager)
        {
            this.noteManager = noteManager;
        }
        
        [HttpGet("notes")]
        public IEnumerable<NoteDTO> GetNotes()
        {
            return noteManager.GetAllNotes();
        }
        
    }
}
