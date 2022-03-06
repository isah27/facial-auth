using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class BACKUP : Form
    {
        public BACKUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PinTbox.Text!="" && ColorTbox.Text != "")
            {
                backup_plan();
            }
            else
            {
                MessageBox.Show("PLEASE ENTER YOUR SECRETE PIN AND FAVORITE COLOR NAME");
            }
           
        }
        
        void backup_plan()
        {
            string pin = PinTbox.Text.Trim();
            string color = ColorTbox.Text.Trim();
            string query = "SELECT * FROM backup_plan";
            string querry = "INSERT INTO backup_plan([SECRETE PIN], [FAVOURITE COLOR]) VALUES(@PIN, @COLOR)";
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                con.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows.Count >0)
                {
                    foreach (DataRow dr in data.Rows)
                    {
                        pin = (string)dr["SECRETE PIN"];
                        color = (string)dr["FAVOURITE COLOR"];
                        if(pin==PinTbox.Text.Trim()  && color == ColorTbox.Text.Trim())
                        {
                            HOME h = new HOME();
                            h.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Details");
                        }
                    }

                        
                   
                }
                else
                {
                    SQLiteCommand cmd = new SQLiteCommand(querry, con);
                    cmd.Parameters.AddWithValue("@PIN", pin);
                    cmd.Parameters.AddWithValue("@COLOR", color);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUCCESSFUL.\nYOUR SECRET PIN IS "+pin+".\nYOUR FAVORITE COLOR IS "+color+".");
                    WELCOME_PAGE h = new WELCOME_PAGE();
                    h.Show();
                    this.Hide();
                }
            }
        }


    }
}
