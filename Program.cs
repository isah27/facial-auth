using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Authentication
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             using(SQLiteConnection con=new SQLiteConnection(connections.connectionStrings()))
             {
                 con.Open();
                 SQLiteDataAdapter sqldt = new SQLiteDataAdapter("SELECT * FROM Face", con);
                 DataTable dt = new DataTable();
                 sqldt.Fill(dt);
                 if (dt.Rows.Count <1)
                 {
                     Application.Run(new SIGN_UP());

                 }
                 else
                 {

                     Application.Run(new WELCOME_PAGE());
                 }
             }
            

        }
    }
}
