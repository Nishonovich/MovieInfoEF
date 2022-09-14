using MovieInfoEF.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class MovieDirector : BaseEntity
    {
        public Int64 DirectorId { get; set; }
        public virtual Director Director { get; set; } // directorId foren key qilish 
        public Int64 MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        // foren key qilinganda warningni hal qilsh uchun constructirda obekt olib qo'yish k/k
        public MovieDirector() 
        {
            Movie = new Movie();
            Director = new Director();
        }
    }
}
