using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Simple_Currency_Exchange_System.Entities;

namespace Simple_Currency_Exchange_System.Entities
{
    public class Country
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}

namespace Simple_Currency_Exchange_System.Mapping
{
    public sealed class CountryMap : ClassMap<Country>, IFluentMapping
    {
        public CountryMap()
        {
            Table("COUNTRIES");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name).Not.Nullable();
        }
    }
}
