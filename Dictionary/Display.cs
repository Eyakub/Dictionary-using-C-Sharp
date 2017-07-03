using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Display : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eyakub\Documents\dictionary.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;

        private readonly MaterialSkinManager materialSkinManager;
        public Display()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            sd = new SqlDataAdapter(@"SELECT * FROM mydic", con);
            dt = new DataTable();
            sd.Fill(dt);
            mydicDataGridView.DataSource = dt;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.mydic' table. You can move, or remove it, as needed.
            //this.mydicTableAdapter1.Fill(this.appData.mydic);
            
        }

        private void Edit(bool value)
        {
            
        }
        

        private void displayQueryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mydicTableAdapter1.displayQuery(this.appData.mydic);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this word?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mydicDataGridView.Rows.Count >= 1 && mydicDataGridView.SelectedRows[0].Index != mydicDataGridView.Rows.Count - 1)
                    {
                        string a = mydicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        string sql = "DELETE FROM mydic WHERE id='" + a + "'";
                        con.Open();
                        SqlCommand delcmd = new SqlCommand(sql, con);
                        delcmd.Connection = con;
                        int x = delcmd.ExecuteNonQuery();
                        con.Close();
                        mydicDataGridView.Rows.RemoveAt(mydicDataGridView.SelectedRows[0].Index);
                        MessageBox.Show(x.ToString() + " " + "Word Deleted !", "Warning");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sc = new SqlCommandBuilder(sd);
                sd.Update(dt);
                MessageBox.Show("updated !!");
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}


='<%#Eval("path")%>' runat = "server"
