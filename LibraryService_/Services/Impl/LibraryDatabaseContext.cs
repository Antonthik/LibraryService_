using LibraryService_.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LibraryService_.Services.Impl
{
    public class LibraryDatabaseContext : ILibraryDatabaseContextService
    {
        private IList<Book> _libraryDatabase;

        public IList<Book> Books => _libraryDatabase;


        public LibraryDatabaseContext()
        {
            Initialize();
        }


        private void Initialize()
        {
            _libraryDatabase =
                 (List<Book>)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(Properties.Resources.books), typeof(List<Book>));//берем из ресурсов приложения- в свойстве сервиса можно в разделе "Ресурсы" задать источник данных-добавляем файл с данными
        }

    }
}