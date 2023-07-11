using Diary.Api.Models;

namespace Diary.Api.Interfaces
{
    public interface INoteManager
    {
        IList<NoteDTO> GetAllNotes();
    }
}
