using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.DTO_s.Director
{
    public class DirectorViewModel
    {
        public Int64 Id { get; set; }      
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public bool? IsMale { get; set; }
        public DateOnly BirthDate { get; set; }
        public String Position { get; set; } = String.Empty;
        public String Hobby { get; set; } = String.Empty;
    }
}
