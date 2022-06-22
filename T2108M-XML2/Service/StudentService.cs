using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_XML2.ListView;

using T2108M_XML2.Helper;
using SQLitePCL;

namespace T2108M_XML2.Service
{
    interface IStudentService
    {
        List<Student> all();
        void Create(Student s);
        void Update(Student s);
        void Delete(Student s); 
    }
    class StudentService : IStudentService
    {
        public List<Student> all()
        {
            string sql_txt = "select * from Student";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            var list = new List<Student>();
            while(SQLiteResult.ROW == statement.Step())
            {
                Student s = new Student()
                {
                    Id = Convert.ToInt32(statement[0]),
                    Name = statement[1] as string,
                    Age = Convert.ToInt32(statement[2]),
                    Address = statement[2] as string,
                };
                list.Add(s);
            }
            return list;
        }

        public void Create(Student s)
        {
            string txt = "insert into Student(Id, Name, Age, Address) values(?,?,?,?)";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(txt);
            statement.Bind(1, s.Id);
            statement.Bind(2, s.Name);
            statement.Bind(3, s.Age);
            statement.Bind(4, s.Address);
            statement.Step();
        }

        public void Delete(Student s)
        {
            string txt = "delete from Student(Id,Name,Age,Address) values(?,?,?,?)";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(txt);
            
           
        }
        public void Update(Student s)
        {
            string txt = "update from Student(Id,Name,Age,Address) values(?,?,?,?)";
        }
    }
}
