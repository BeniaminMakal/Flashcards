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
        
        public int insert_data(string collection, string foreign_language, string foreign_word, string translation_language, string translation, string data)
        {
            int result = 0;
            using (var transaction = this.conn1.BeginTransaction())
            using (var Comm = new FbCommand())

                try
               {
                    Comm.Transaction = transaction;

                    Comm.CommandText = @"INSERT INTO " + foreign_language + " "+
                    "(WORD) VALUES ('"+ foreign_word + "');";
                    Comm.ExecuteNonQuery();

                    Comm.CommandText = @"INSERT INTO " + translation_language +
                        "(WORD) VALUES ('" + translation +"');";
                    Comm.ExecuteNonQuery();

                    Comm.CommandText = @"INSERT INTO " + collection + "" +
                        " (FOREIGN_word, PL_word, Last_Actualization)" +
                        " VALUES ('" +foreign_word +"', '" + translation +
                        "', '" + data + "');";

               
                result = Comm.ExecuteNonQuery();
                    transaction.Commit();
                return result;
                
              }
            finally
            {
                if(conn1 != null)
                conn1.Close();
            }
        }
        public void CreateCollection (string newCollection)
        {

            using (var transaction = this.conn1.BeginTransaction())
            using (var Comm = new FbCommand())

                try
                {
                    Comm.Connection = this.conn1;
                    Comm.Transaction = transaction;

                    Comm.CommandText = @"CREATE TABLE " + newCollection + " " +
                        "(Collection_name VARCHAR (255) NOT NULL," +
                        " Foreign_language VARCHAR (255) NOT NULL," +
                        " Foreign_word VARCHAR (255) NOT NULL PRIMARY KEY," +
                        "  Translation_language VARCHAR (255) NOT NULL," +
                        " Translation_word VARCHAR (255) NOT NULL," +
                        " Actualization TIMESTAMP NOT NULL," +
                        " Owner VARCHAR (255) NOT NULL," +
                        " Status int DEFAULT 1);";

                    Comm.ExecuteNonQuery();

                    Comm.CommandText = @"INSERT INTO Collections " +
                        "(Collection_name, owner) " +
                        "VALUES ('" + newCollection + "'," +
                        " 'sysdba');";
                    Comm.ExecuteNonQuery();

                    transaction.Commit();


                }
                finally
                {
                    if (conn1 != null)
                        conn1.Close();
                }
        }
        public IList<object[]>  FindLanguages()
        {
            using (var Comm = new FbCommand())
            {
                Comm.Connection = this.conn1;
                Comm.CommandText = "SELECT * FROM Languages;";
                using (var reader = Comm.ExecuteReader())
                {
                    var rows = new List<object[]>();
                    while (reader.Read())
                    {
                        var columns = new object[reader.FieldCount];
                        reader.GetValues(columns);
                        rows.Add(columns);
                    }
                    return rows;
                }
            }
        }

    }
   
}
