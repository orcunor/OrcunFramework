using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcunFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory   // lazy loading, navigating durumları için virtual kullanıyorum
        {
            get
            {
                if (_sessionFactory == null)
                    _sessionFactory = InitializeFactory();

                return _sessionFactory;
            } 
        }

        protected abstract ISessionFactory InitializeFactory(); 

        public virtual ISession OpenSession()
        {
            return _sessionFactory.OpenSession();   
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
