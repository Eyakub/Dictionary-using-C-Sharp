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
    public partial class AddDictionary : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eyakub\Documents\dictionary.mdf;Integrated Security=True;Connect Timeout=30");
        public AddDictionary()
        {
            InitializeComponent();
           
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
    }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdd.Text != "" && txtMeaning.Text != "")
                {
                    SqlDataAdapter mc = new SqlDataAdapter(@"Insert into mydic(word, mean)
                    Values(N'" + txtAdd.Text + "', N'" + txtMeaning.Text + "')", con);

                    DataTable dt = new DataTable();
                    mc.Fill(dt);
                    MessageBox.Show("Successfully Inserted", "Message");
                    con.Close();
                    txtAdd.Text = "";
                    txtMeaning.Text = "";
                }
                else
                {
                    MessageBox.Show("Add value First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDictionary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.mydic' table. You can move, or remove it, as needed.
            //this.mydicTableAdapter.Fill(this.appData.mydic);

        }
    }
}
