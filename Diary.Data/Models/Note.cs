using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        
        [Required]
        public string NoteName { get; set; }
        [Required]
        public string NoteDescription { get; set; }
        [Required]
        public DateTime NoteDate { get; set; }
    }
}
