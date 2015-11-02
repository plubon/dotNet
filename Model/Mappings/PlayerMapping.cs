﻿using FluentNHibernate.Mapping;
using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mappings
{
    class PlayerMapping : ClassMap<Player>
    {
        public PlayerMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Nationality);
            HasManyToMany(x => x.Teams)
                .Cascade.All()
                .Table("Players_Teams");
        }
    }
}
