using MovieInfoEF.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class MovieHero : BaseEntity
    {
        public Int64 ActorId { get; set; }
        public virtual Actor Actor { get; set; }
        public Int64 MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        [MaxLength(32)]
        public String HeroName { get; set; } = String.Empty;

        // foren key qilinganda warningni hal qilsh uchun constructirda obekt olib qo'yish k/k
        public MovieHero()
        {
            Actor = new Actor();
            Movie = new Movie();
        }
    }
}
