using AutoMapper;
using Diary.Api.Interfaces;
using Diary.Api.Models;
using Diary.Data.Interfaces;
using Diary.Data.Models;

namespace Diary.Api.Managers
{
    public class NoteManager : INoteManager
    {
        private readonly INoteRepository noteRepository;
        private readonly IMapper mapper;


        public NoteManager(INoteRepository noteRepository, IMapper mapper)
        {
            this.noteRepository = noteRepository;
            this.mapper = mapper;
        }
        public IList<NoteDTO> GetAllNotes()
        {
            IList<Note> notes = noteRepository.GetAll();
            return mapper.Map<IList<NoteDTO>>(notes);

        }
    }
}
