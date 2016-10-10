using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;
using PlaceToPlay.Domain.Models.Identity;

namespace PlaceToPlay.Domain.Models.Cities
{
    /// <summary>
    /// The city where will be registerted different places for playing
    /// </summary>
    public class City : Entity
    {
        public City()
        {
            Users = new List<User>();
        }
        /// <summary>
        /// Name that will be displayed on UI
        /// </summary>
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}
