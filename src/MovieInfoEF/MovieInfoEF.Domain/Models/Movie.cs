using MovieInfoEF.Domain.Commons;
using MovieInfoEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class Movie : Auditable
    {
        [MaxLength(32)]
        public String Name { get; set; } = String.Empty;
        public DateOnly MovieYear { get; set; }
        public String Duration { get; set; } = String.Empty;
        [MaxLength(32)]
        public String Language { get; set; } = String.Empty;
        public String ImagePath { get; set; } = String.Empty;
        public DateOnly PremiereDate { get; set; }
        public Country Country { get; set; }
        public Movie()
        {
            Country = Country.Uzbekistan;
        }


    }
}
