using Npgsql;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Responsi_Novaldy
{
    public partial class Form1 : Form
    {
        public static NpgsqlCommand cmd;
        public DataTable dt;
        private NpgsqlConnection conn;
        private string? sql = null;
        private DataGridViewRow r;
        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from ";
                cmd = new NpgsqlCommand();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}