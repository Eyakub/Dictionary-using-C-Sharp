using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Dictionary
{
    public partial class DictionaryMain : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eyakub\Documents\dictionary.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;
        DataView dv;

        public DictionaryMain()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDictionary add = new AddDictionary();
            add.Show();
        }

        private void updateWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDictionary update = new UpdateDictionary();
            update.Show();
        }

        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDictionary delete = new DeleteDictionary();
            delete.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Display ds = new Display();
                ds.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string st = txtSearch.Text;

                    string sql = "Select mean from mydic where word LIKE  '%" + st + "%'";

                    sd = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    sd.Fill(dt);
                    dv = new DataView(dt);
                    lvlMeaning.Text = Convert.ToString(dt.Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Input first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DictionaryMain_Load(object sender, EventArgs e)
        {

        }
    }
}
