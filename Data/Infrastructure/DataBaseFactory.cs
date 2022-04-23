using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PS.Data.Infrastructure
{
    public class DataBaseFactory : Disposable, IDataBaseFactory

    {
        public DataBaseFactory()
        {
            dataContext = new Context();
        }

        private DbContext dataContext;

        public DbContext DataContext => dataContext;

        protected override void DisposeCore()
        {
            dataContext?.Dispose();
        }
    }
}