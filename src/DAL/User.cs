﻿using System;
using System.Collections.Generic;

namespace DAL
{
    public partial class User
    {
        public User()
        {
            Event = new HashSet<Event>();
            Publication = new HashSet<Publication>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Event { get; set; }
        public ICollection<Publication> Publication { get; set; }
    }
}
