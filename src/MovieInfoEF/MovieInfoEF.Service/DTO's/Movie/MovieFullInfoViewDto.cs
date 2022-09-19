using MovieInfoEF.Domain.Enums;
using MovieInfoEF.Service.DTO_s.Actors;
using MovieInfoEF.Service.DTO_s.Director;
using MovieInfoEF.Service.DTO_s.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.DTO_s.Movie
{
    public class MovieFullInfoViewDto
    {
        public Int64 Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public DateOnly MovieYear { get; set; }
        public String Duration { get; set; } = String.Empty;
        public String Language { get; set; } = String.Empty;
        public String ImagePath { get; set; } = String.Empty;
        public DateOnly PremiereDate { get; set; }
        public Country Country { get; set; }
        public IEnumerable<DirectorViewModel> Directors { get; set; }
        public IEnumerable<ActorViewModel> Actors { get; set; }
        public IEnumerable<GenreViewModel> Genres { get; set; }
    }
}
