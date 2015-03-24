using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace _7DTD_Manager
{
    class SQLite
    {
        string DBPATH = Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.ApplicationData), "7dtd_manager.sqlite");
        SQLiteConnection db;
        SQLiteCommand cmd;

        public SQLite(bool create)
        {
            if (create == true)
            {
                try
                {
                    db = new SQLiteConnection("Data Source=" + DBPATH + ";Version=3;");
                    db.Open();
                    string query = "CREATE TABLE hosts (name VARCHAR(30), host VARCHAR(15), password VARCHAR(40), port INT)";
                    cmd = new SQLiteCommand(query, db);
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    Console.Write(e.Message);
                }
            }
            else
            {
                try
                {
                    db = new SQLiteConnection("Data Source=" + DBPATH + ";Version=3;");
                    db.Open();
                }
                catch (SQLiteException e)
                {
                    Console.Write(e.Message);
                }
            }
        }

        public bool executeQuery(string query){
            try{
                cmd = new SQLiteCommand(query, db);
                cmd.ExecuteNonQuery();
            }catch(SQLiteException e){
                return false;
            }
            
            return true;
        }

        public SQLiteDataReader selectQuery(string query)
        {
            cmd = new SQLiteCommand(query, db);
            SQLiteDataReader dr = cmd.ExecuteReader();

            return dr;
        }
    }
}
