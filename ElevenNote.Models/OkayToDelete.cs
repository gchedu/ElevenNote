using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class OkayToDelete
    {   
        [Key]
        public int Id { get; set; }
        public string SomeColumn { get; set; }
    }
}
