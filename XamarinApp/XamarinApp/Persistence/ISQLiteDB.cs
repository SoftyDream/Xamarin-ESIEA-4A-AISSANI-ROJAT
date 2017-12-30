/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using System.IO;
using XamarinApp.Persistence;
using XamarinApp.Droid.Persistence;
using Xamarin.Forms;

//SQLite Interface
//iOS implementation SQLite

[assembly: Dependency(typeof(SQLiteDB))]

namespace XamarinApp.Droid.Persistence
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);

        }
       
    }
}
*/