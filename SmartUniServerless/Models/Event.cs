using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartUniServerless.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        //public IList<UserEvent> UserEvents { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
