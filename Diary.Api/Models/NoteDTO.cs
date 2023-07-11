namespace Diary.Api.Models
{
    public class NoteDTO
    {
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string NoteDescription { get; set; }
        public DateTime NoteDate { get; set; }

     }
}
