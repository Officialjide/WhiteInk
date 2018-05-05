using Ink.Core;
using Ink.Core.Domain;
using Ink.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Infrastructure.Repositories
{
    public class CenterRepository : Repository<Center>, ICenterRepository
    {
        public CenterRepository(TakesContext context) : base (context)
        {

        }
        public TakesContext TakesContext
        {
            get { return Context as TakesContext; }
        }
    }
}
