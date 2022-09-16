using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieInfoEF.Domain.Models;

namespace MovieInfoEF.Service.DTO_s.Actors
{
    public class ActorViewModel
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Hobby { get; set; } = String.Empty;
        public bool? IsMale { get; set; }
        public DateOnly BirthDate { get; set; }        

    }
}
