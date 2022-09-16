using MovieInfoEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.DTO_s.Movie
{
    public class MovieViewModel
    {
        public Int64 Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public DateOnly MovieYear { get; set; }
        public String Duration { get; set; } = String.Empty;
        public String Language { get; set; } = String.Empty;
        public String ImagePath { get; set; } = String.Empty;
        public DateOnly PremiereDate { get; set; }
        public Country Country { get; set; }
    }
}
