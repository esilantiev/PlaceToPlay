using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Domain.Models.Identity
{
    public class UserClaim : Entity
    {
        public User User { get; set; }


        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
