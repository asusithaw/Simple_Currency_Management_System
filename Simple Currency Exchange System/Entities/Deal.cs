using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Simple_Currency_Exchange_System.Entities;

public enum Action
{
    Buy,
    Sell
}
namespace Simple_Currency_Exchange_System.Entities
{
    public class Deal
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Customer { get; set; }
        public virtual Action Action { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual decimal Rate { get; set; }
        public virtual decimal Nett { get; set; }
        public virtual User User { get; set; }

        public virtual string ActionName
        {
            get { return Action.ToString(); }
        }
    }
}

namespace Simple_Currency_Exchange_System.Mapping
{
    public sealed class DealMap : ClassMap<Deal>, IFluentMapping
    {
        public DealMap()
        {
            Table("DEALS");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Date);
            Map(x => x.Customer);
            Map(x => x.Action).CustomType<int>();
            Map(x => x.Amount);
            References(x => x.Currency).Column("CurrencyId").Not.LazyLoad();
            Map(x => x.Rate);
            Map(x => x.Nett);
            References(x => x.User).Column("UserId").Not.LazyLoad();
        }
    }
}
