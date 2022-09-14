using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Commons
{
    public class Auditable : BaseEntity
    {
        public DateOnly CreatedDate { get; set; }
        public DateOnly UpdatedDate { get; set; }
    }
}
