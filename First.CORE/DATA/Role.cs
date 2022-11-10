﻿using System;
using System.Collections.Generic;

#nullable disable

namespace First.CORE.DATA
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public decimal Id { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
