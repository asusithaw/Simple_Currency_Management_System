using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace Simple_Currency_Exchange_System
{
    public class SessionScope : IDisposable
    {
        [ThreadStatic]
        private static ISession _currentSession;

        public static ISession CurrentSession
        {
            get { return _currentSession; }
        }

        public SessionScope()
        {
            _currentSession = NHibernateHelper.OpenSession();
        }

        public void Dispose()
        {
            if (_currentSession != null)
            {
                _currentSession.Dispose();
                _currentSession = null;
            }
        }
    }
}
