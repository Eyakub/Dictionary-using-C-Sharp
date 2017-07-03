using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class DeleteDictionary : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=dictionary;pwd=mdes;");
        MySqlDataAdapter md;
        DataTable dt;
        MySqlCommandBuilder mcb;
        MySqlCommand mc;
        private readonly MaterialSkinManager materialSkinManager;
        public DeleteDictionary()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DeleteDictionary_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string inp = txtDelete.Text;
                mc = new MySqlCommand(@"Delete from mydic where id ");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
