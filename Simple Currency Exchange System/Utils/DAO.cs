using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace Simple_Currency_Exchange_System.Utils
{
    public class DAO<T>
    {
        public static T Load(object id)
        {
            using (var scope = new SessionScope())
            {
                return SessionScope.CurrentSession.Load<T>(id);
            }
        }

        public static T Get(object id)
        {
            using (var scope = new SessionScope())
            {
                return SessionScope.CurrentSession.Get<T>(id);
            }
        }

        public static void Refresh(T obj)
        {
            using (var scope = new SessionScope())
            {
                SessionScope.CurrentSession.Refresh(obj);
            }
        }

        public static T FindByProperty(string property, object value)
        {
            using (var scope = new SessionScope())
            {
                IList<T> list = SessionScope.CurrentSession.CreateCriteria(typeof(T))
                    .Add(Expression.Eq(property, value))
                    .List<T>();

                return list.FirstOrDefault();
            }
        }

        public static IList<T> FindAllByProperty(string property, object value)
        {
            using (var scope = new SessionScope())
            {
                return SessionScope.CurrentSession.CreateCriteria(typeof(T))
                    .Add(Expression.Eq(property, value))
                    .List<T>();
            }
        }

        public static IList<T> ListAll()
        {
            using (var scope = new SessionScope())
            {
                return SessionScope.CurrentSession.CreateCriteria(typeof(T)).List<T>();
            }
        }

        public static void Save(params T[] objs)
        {
            using (var scope = new SessionScope())
            {
                using (ITransaction txn = SessionScope.CurrentSession.BeginTransaction())
                {
                    foreach (var obj in objs)
                    {
                        SessionScope.CurrentSession.SaveOrUpdate(obj);
                    }
                    txn.Commit();
                }
            }
        }

        public static void Update(T obj)
        {
            using (var scope = new SessionScope())
            {
                using (ITransaction txn = SessionScope.CurrentSession.BeginTransaction())
                {
                    SessionScope.CurrentSession.Update(obj);
                    txn.Commit();
                }
            }
        }

        public static void Delete(T obj)
        {
            using (var scope = new SessionScope())
            {
                using (ITransaction txn = SessionScope.CurrentSession.BeginTransaction())
                {
                    SessionScope.CurrentSession.Delete(obj);
                    txn.Commit();
                }
            }
        }
    }
}
