using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Authentication
{
    public partial class HOME : Form
    {

        public HOME()
        {
            InitializeComponent();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            HomeBtn.Visible = true;
            DataPanel.Visible = true;
            contentPanel.Visible = false;
            openNestForm(new AddNumbber());
        }

        private void AddpersonBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {

                con.Open();


                string Query = "SELECT * FROM Face";
                SQLiteDataAdapter sqladp = new SQLiteDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sqladp.Fill(dt);
                int count = dt.Rows.Count;
                if (count < 20)
                {
                    SIGN_UP s = new SIGN_UP();
                    s.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry. You cannot add more than two user!!!");
                }
                
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openNestForm(Form nestForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = nestForm;
            nestForm.TopLevel = false;
            nestForm.FormBorderStyle = FormBorderStyle.None;
            nestForm.Dock = DockStyle.Fill;
            DataPanel.Controls.Add(nestForm);
            DataPanel.Tag = nestForm;
            nestForm.BringToFront();
            nestForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            DataPanel.Visible = false;
            contentPanel.Visible = true;
            HomeBtn.Visible = false;
            
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }
        

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Visible = false;
           
            DataPanel.Visible = true;
            HomeBtn.Visible = true;
            openNestForm(new ContactHelp());
        }
    }
}
