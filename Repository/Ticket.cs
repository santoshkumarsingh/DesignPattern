using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class Ticket
    {

        public Ticket(string title, string desc)
        {
            this.title = title;
            this.desc = desc;
        }

        public string title { get; set; }
        public string desc { get; set; }
    }
}
