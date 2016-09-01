using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PlaceToPlay.Api.Models
{
    public class AuthRepository : IDisposable
    {
        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            var users = new List<IdentityUser>()
            {
                new IdentityUser() { UserName = "evgheni", Password = "12345678" },
                new IdentityUser() { UserName = "mark", Password = "12345678" }
            };

            return users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }

        public void Dispose()
        {
            
        }
    }
}