using LibraryService_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService_.Services
{
    public interface ILibraryDatabaseContextService
    {
        IList<Book> Books { get; }
    }
}
