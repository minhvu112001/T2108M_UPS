using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Windows.Storage;
using System.IO;


namespace T2108M_XML2.Helper
{
    class SQLiteHelper
    {
        private readonly string dbName = "t2108m.db";
        public ISQLiteConnection SQLiteConnection { get; set; }
        private static SQLiteHelper sQLiteHelper;

        

       

        private SQLiteHelper()
        {
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
            SQLiteConnection = new SQLiteConnection(path);

            var sql_txt = @"create table if not exists Student(Id integer primary key , Home varchar(255), age integer, address varchar(255) )";
            var statement = SQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }

        public static SQLiteHelper GetInstance()
        {
            if (sQLiteHelper == null)
                sQLiteHelper = new SQLiteHelper();
            return sQLiteHelper;
        }
    }

}
