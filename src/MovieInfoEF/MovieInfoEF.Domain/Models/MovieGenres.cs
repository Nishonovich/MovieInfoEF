using MovieInfoEF.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class MovieGenres : BaseEntity
    {
        public Int64 MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public Int64 GenresId { get; set; }
        public virtual Genres Genres { get; set; }

        // foren key qilinganda warningni hal qilsh uchun constructirda obekt olib qo'yish k/k
        public MovieGenres()
        {
            Movie = new Movie();
            Genres = new Genres();
        }
    }
}
