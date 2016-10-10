using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceToPlay.Data.Infrastructure.Abstract;

namespace PlaceToPlay.Domain.Models.Identity
{
    public class Token : Entity
    {
        //public TokenType TokenType { get; set; }    
       
        public string Key { get; set; }        
        
        public string Type { get; set; }
        
        public DateTimeOffset Expiry { get; set; }

        public User User { get; set; }
    }
}
