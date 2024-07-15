using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Simple_Currency_Exchange_System.Entities;
using NHibernate;

namespace Simple_Currency_Exchange_System.Entities
{
    public class Currency
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual Country Country { get; set; }
        public virtual decimal MiddleRate { get; set; }
        public virtual decimal BuyRate { get; set; }
        public virtual decimal SellRate { get; set; }
    }
}

namespace Simple_Currency_Exchange_System.Mapping
{
    public sealed class CurrencyMap : ClassMap<Currency>, IFluentMapping
    {
        public CurrencyMap()
        {
            Table("CURRENCIES");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Code);
            Map(x => x.Name);
            Map(x => x.IsActive);
            References(x => x.Country).Column("CountryId").Not.LazyLoad();
            Map(x => x.MiddleRate);
            Map(x => x.BuyRate);
            Map(x => x.SellRate);
        }
    }
}
