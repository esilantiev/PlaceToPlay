using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;
using PlaceToPlay.Domain.Models.Cities;

namespace PlaceToPlay.Domain.Models.Identity
{
    public class User : Entity
    {
        public City City { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; }        

    }
}
