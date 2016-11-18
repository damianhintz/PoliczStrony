using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StronyA4.Domena.Abstrakcje;

namespace StronyA4.EntityFramework
{
    public class StronyA4Db : DbContext
    {
        IQueryable<IStrona> Strony { get; }
    }
}
