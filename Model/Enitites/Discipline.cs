﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class Discipline
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<League> Leagues { get; set; }
        public virtual IList<Team> Teams { get; set; }
    }
}
