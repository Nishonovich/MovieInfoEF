using MovieInfoEF.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class Director : Auditable
    {
        [MaxLength(32)]
        public String FirstName { get; set; } = String.Empty;
        [MaxLength(32)]
        public String LastName { get; set; } = String.Empty;
        [DefaultValue(true)]
        public bool? IsMale { get; set; }
        public DateOnly BirthDate { get; set; }
        [MaxLength(32)]
        public String Position { get; set; } = String.Empty;
        public String Hobby { get; set; } = String.Empty;
    }
}
