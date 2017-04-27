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
        
    }
}
