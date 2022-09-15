using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.DTO_s.Actors
{
    public class ActorCreateDto
    {
        [MaxLength(32)]
        public string FirstName { get; set; } = String.Empty;
        [MaxLength(32)]
        public string LastName { get; set; } = String.Empty;
        public string Hobby { get; set; } = String.Empty;
        [DefaultValue(true)]
        public bool? IsMale { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
