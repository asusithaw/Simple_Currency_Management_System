using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernate;
using Simple_Currency_Exchange_System.Entities;
using NHibernate.Criterion;

namespace Simple_Currency_Exchange_System.Entities
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual bool IsActive { get; set; }

        public static User CurrentUser = null;

        public static void Login(string userName, string password)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    User user = session.CreateCriteria(typeof(User))
                        .Add(Expression.Eq("UserName", userName))
                        .Add(Expression.Eq("Password", password))
                        .UniqueResult<User>();

                    if (user == null)
                        throw new Exception("Invalid username or password!");

                    User.CurrentUser = user;
                }
            }

        }
    }
}

namespace Simple_Currency_Exchange_System.Mapping
{
    public sealed class UserMap : ClassMap<User>, IFluentMapping
    {
        public UserMap()
        {
            Table("USERS");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.IsActive);
        }
    }
}
