using AutoMapper;
using Diary.Api.Models;
using Diary.Data.Models;

namespace Diary.Api
{
    public class AutomapperConfigurationProfile : Profile
    {
        public AutomapperConfigurationProfile()
        {

            CreateMap<NoteDTO, Note>();
            CreateMap<Note, NoteDTO>();
        }
    }
}