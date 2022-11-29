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
        string connstring = "Host=LocalHost;Port=2022;Username=novaldy;Password=informatika;Database=responsi";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = @"select * from departemen(:id_dep,:nama_dep)";
                cmd = new NpgsqlCommand();
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from insert_data(:_nama,:_idDep)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama", tbNama.Text);
            cmd.Parameters.AddWithValue("id_dep", tbDep.Text);
            if((int)cmd.ExecuteScalar() == 1)
            {
                try
                {
                    MessageBox.Show("Data User Berhasil Diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = tbDep.Text = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}