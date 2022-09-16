using MovieInfoEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Service.DTO_s.User
{
    public class UserViewModel
    {
        public Int64 Id { get; set; }   
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public bool? Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public String Email { get; set; } = String.Empty;
        public String PhoneNumber { get; set; } = String.Empty;
        public String Login { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
        public UserPosit UserPosit { get; set; }
    }
}
