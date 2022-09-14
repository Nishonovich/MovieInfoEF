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
    public class User : Auditable
    {
        [MaxLength(32)]
        public String FirstName { get; set; } = String.Empty;
        [MaxLength(32)]
        public String LastName { get; set; } = String.Empty;
        [DefaultValue(true)]
        public bool? Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        [EmailAddress,MaxLength(50)]
        public String Email { get; set; } = String.Empty;
        [Phone, MaxLength(13)]
        public String PhoneNumber { get; set; } = String.Empty;
        [MinLength(6)]
        public String Login { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;

        public UserPosit UserPosit { get; set; }
        public User()
        {
            UserPosit = Enums.UserPosit.User;
        }
    }
}
