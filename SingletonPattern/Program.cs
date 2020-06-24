using System;

namespace SingletonPattern
{
    class DBConnect
    {
        private static DBConnect instance;
        private DBConnect()
        {
            Console.WriteLine("Creating connection...");
        }

        public static DBConnect GetInstance()
        {
            if(instance == null)
            {
                instance = new DBConnect();
            }
            return instance;
        }

        public void ExecSQL(string query)
        {
            Console.WriteLine(query);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var connection1 = DBConnect.GetInstance();
            connection1.ExecSQL("select * \nfrom table1");

            Console.WriteLine();

            var connection2 = DBConnect.GetInstance();
            connection2.ExecSQL("insert into table2 \nselect * \nfrom table1");

            Console.Read();
        }
    }
}
