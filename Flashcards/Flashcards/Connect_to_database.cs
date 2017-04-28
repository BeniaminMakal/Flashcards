using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flashcards
{
    class Connect_to_database
    {
        private FbConnection conn1;
        public Connect_to_database()
        {
            const string database = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\Flashcards\Flashcards\FLASH_CARDS.FDB";
            string connectionstring;
            FbConnectionStringBuilder ConString = new FbConnectionStringBuilder();
            ConString.Database = database;
            ConString.ServerType = FbServerType.Embedded;
            ConString.UserID = "sysdba";
            connectionstring = ConString.ToString();

            conn1 = new FbConnection(connectionstring);
                //open connection

                conn1.Open();

            
            
        }
            public DataTable get_data(string q)
        {
            FbDataReader reader = null;
            try
            {
                DataTable dt = new DataTable();
                FbCommand Comm = new FbCommand(q);
                Comm.Connection = this.conn1;
                reader = Comm.ExecuteReader();
                dt.Load(reader);

                return dt;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (conn1 != null)
                    conn1.Close();
            }


        }
        
        public int insert_data(string table, string foreign_word, string translation, string data)
        {
            int result = 0, result2 = 0;

            try
            {
                FbCommand Comm = new FbCommand("INSERT INTO " + table + " (FOREIGN_word, PL_word, Last_Actualization) VALUES ('" +foreign_word +"', '" + translation +"', '" + data + "');");

                Comm.Connection = this.conn1;
                result = Comm.ExecuteNonQuery();
                return result;
                if(result > 0)
                {
                    FbCommand Comm2 = new FbCommand("commit;");
                    Comm2.Connection = this.conn1;
                    result2 = Comm2.ExecuteNonQuery();
                    
                }
            }
            finally
            {
                if(conn1 != null)
                conn1.Close();
            }

            
        }
    }
   
}
