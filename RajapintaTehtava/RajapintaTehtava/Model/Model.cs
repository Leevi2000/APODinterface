using RajapintaTehtava.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
namespace RajapintaTehtava.Model
{
    /// <summary>
    /// Grants a possibility for user to save/bookmark interesting pictures.
    /// </summary>
    internal class Model
    {

        string connectionStringWithoutDB = "Data Source=" + System.IO.Directory.GetCurrentDirectory() + ";";
        string connectionString = "Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\RajapintaTehtava.db;";

        /// <summary>
        /// Returns true if saving to database succeeded.
        /// </summary>
        /// <param name="bookmark"></param>
        /// <returns></returns>
        public bool SaveBookMark(Controller.Bookmark bookmark)
        {
            string cmd = $"INSERT INTO Bookmarks (Name, Date) VALUES ('{bookmark.Name}', '{bookmark.Date.ToString("yyyy-MM-dd")}')";
            return ExecuteCommand(cmd);
        }

        /// <summary>
        /// Returns true if deleting from database succeeded.
        /// </summary>
        /// <param name="bookmark"></param>
        /// <returns></returns>
        public bool DeleteBookmark(int bookmarkId)
        {
            string cmd = $"DELETE FROM Bookmarks WHERE Id={bookmarkId}";
            return ExecuteCommand(cmd);
        }

        /// <summary>
        /// Gets a list of bookmarks from database.
        /// </summary>
        /// <returns></returns>
        public List<Bookmark> GetBookmarks()
        {
            DataTable bookmarksDataTable;
            List<Bookmark> bookmarkList = new List<Bookmark>();
            string cmd = "SELECT * FROM Bookmarks";
            bookmarksDataTable = GetDataTable(cmd);

            foreach (DataRow bm in bookmarksDataTable.Rows)
            {
                Bookmark bookmark = new Bookmark(bm["Name"].ToString(), DateTime.Parse(DateTime.Parse(bm["Date"].ToString()).ToString("yyyy-MM-dd")));
                bookmarkList.Add(bookmark);
            }

            return bookmarkList;
        }

        /// <summary>
        /// Gets the entire datatable of bookmarks from database. 
        /// </summary>
        /// <returns></returns>
        public DataTable GetBookmarkDatatable()
        {
            DataTable bookmarksDataTable;
            string cmd = "SELECT * FROM Bookmarks";
            return bookmarksDataTable = GetDataTable(cmd);
        }

        /// <summary>
        /// Returns a datatable.
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string cmd)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd, conn);

                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            return dataTable;
        }

        /// <summary>
        /// Returns true if database & table exists. Can also create new database and table.
        /// </summary>
        /// <returns></returns>
        public bool VerifyDBTable()
        {
            bool exists = true;
            if (CheckDatabaseExists() == true)
            {
                if (CheckDatatableExists() == false)
                    exists = CreateDatatable();
            }
            else
            {
                CreateDatabase();
                exists = CreateDatatable();
            }
            return exists;
        }

        /// <summary>
        /// Executes a sql command. Returns true/false depending on try/catch.
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="customConnString"></param>
        /// <returns></returns>
        private bool ExecuteCommand(string cmd, string customConnString = "")
        {
            string connString;

            bool success = false;
            if (customConnString == "")
                connString = connectionString;
            else
                connString = customConnString;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    using (SQLiteCommand sqlCmd = new SQLiteCommand(cmd, conn))
                    {
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                        success = true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return success;
        }

        /// <summary>
        /// Creates a datatable for RajapintaTehtava database.
        /// </summary>
        /// <returns></returns>
        private bool CreateDatatable()
        {
            bool success = false;
            try
            {
                string cmd = "CREATE TABLE Bookmarks" +
                        "(" +
                        "Id INTEGER PRIMARY KEY," +
                        "Name TEXT NOT NULL," +
                        "Date TEXT NOT NULL" +
                        ")";
                ExecuteCommand(cmd);
                success = true;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return success;
        }

        /// <summary>
        /// Creates a database called RajapintaTehtava.
        /// </summary>
        /// <returns></returns>
        private bool CreateDatabase()
        {
            bool success = false;
            try
            {
                SQLiteConnection.CreateFile("RajapintaTehtava.sqlite");
                success = true;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return success;
        }

        /// <summary>
        /// Checks datatable existance.
        /// </summary>
        /// <returns></returns>
        private bool CheckDatatableExists()
        {
            bool success = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection())
                {
                    conn.ConnectionString = connectionString;
                    string cmd = "SELECT * FROM sqlite_master WHERE type='table' AND name='Bookmarks'";
                    using (SQLiteCommand sqlCmd = new SQLiteCommand(cmd, conn))
                    {
                        conn.Open();

                        var resultObj = sqlCmd.ExecuteReader();

                        if (resultObj.HasRows)
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                        conn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return success;
        }
         /// <summary>
         /// Checks Database existance.
         /// </summary>
         /// <returns></returns>
        private bool CheckDatabaseExists()
        {
            bool result = false;
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "\\RajapintaTehtava.db";
                if (File.Exists(path))
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}

