using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Authentication
{
    public partial class AddNumbber : Form
    {
        DataTable dtbl;
        public AddNumbber()
        {
            InitializeComponent();
        }

       

        

        private void AddNumbber_Load(object sender, EventArgs e)
        {
            populateDGV();
            
        }
        void fillDataGridView()
        {
            DataView DV = new DataView(dtbl);
            DV.RowFilter=string.Format("NAME LIKE '%{0}%'", Searchtxt.Text);
            dataGridView1.DataSource = DV;
        }
               
        void populateDGV()
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
                {
                    sqlcon.Open();
                    SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM Contact", sqlcon);
                    dtbl = new DataTable();
                    sqlda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    sqlcon.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        void AddContact()
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
                {
                    sqlcon.Open();
                    string comand = "insert into Contact (NAME, [MOBILE NUMBER], [EMAIL ADDRESS]) values (@Name, @PhoneNumber, @EmailAddress)";
                    SQLiteCommand sqlcmd = new SQLiteCommand(comand, sqlcon);
                    sqlcmd.Parameters.AddWithValue("@Name", NameTbox.Text);
                    sqlcmd.Parameters.AddWithValue("@PhoneNumber", MobileTbox.Text);
                    sqlcmd.Parameters.AddWithValue("@EmailAddress", EmailTbox.Text);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added.");
                    ClearTxt();
                    populateDGV();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void UpdateContact()
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                sqlcon.Open();
                
                string comand = "UPDATE Contact SET NAME=@Name, [MOBILE NUMBER]=@PhoneNumber, [EMAIL ADDRESS]=@EmailAddress WHERE Id=@Id";
                SQLiteCommand sqlcmd = new SQLiteCommand(comand, sqlcon);
                sqlcmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@Name", NameTbox.Text);
                sqlcmd.Parameters.AddWithValue("@PhoneNumber", MobileTbox.Text);
                sqlcmd.Parameters.AddWithValue("@EmailAddress", EmailTbox.Text);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!!!");
                ClearTxt();
                populateDGV();
            }
        }
       
        void ClearTxt()
        {
            NameTbox.Text = "";
            MobileTbox.Text = "";
            EmailTbox.Text = "";
        }
       
      
       

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxt.Text != "")
                fillDataGridView();
            else if (Searchtxt.Text == "")
                populateDGV();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (!dataGridView1.CurrentRow.Selected)
                {
                    if (NameTbox.Text != "" && MobileTbox.Text != "" && EmailTbox.Text != "")
                    {
                        AddContact();
                    }
                }
            }
            else
            {
                if (NameTbox.Text != "" && MobileTbox.Text != "" && EmailTbox.Text != "")
                {
                    AddContact();
                }
            }
           
            
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0)
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    UpdateContact();
                }
                else
                {
                    MessageBox.Show("Please select the row you wan to update");
                }

            }
           
            
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.CurrentRow.Selected)
                {
                    NameTbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    MobileTbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    EmailTbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
                else
                {
                    ClearTxt();
                }
            }
           
        }

        private void dataGridView1_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["txtSN"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you Sure to Delete this Record", "DataTable", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
                    {
                        sqlcon.Open();
                        SQLiteCommand sqlcmd = new SQLiteCommand("DELETE FROM Contact WHERE Id=@id", sqlcon);
                        sqlcmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtSN"].Value));
                        sqlcmd.ExecuteNonQuery();
                        ClearTxt();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
