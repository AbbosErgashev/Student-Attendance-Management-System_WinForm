using BookStoreManagmentSystem;
using System.Data;
using System.Data.SqlClient;

namespace StudentAttendanceManagementSystem
{
    public partial class Abiturient : Form
    {
        public Abiturient()
        {
            InitializeComponent();
            GetOliy();
            GetHudud();
            GetImtihon();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Abiturient";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void Save()
        {
            if (itbl.Text == "" || ftbl.Text == "" || oitbl.Text == "" || jtbl.Text == "" || ocb.SelectedIndex == -1 || hcb.SelectedIndex == -1 || icb.SelectedIndex == -1)
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Abiturient values('" 
                        + itbl.Text + "', '" 
                        + ftbl.Text + "', '" 
                        + oitbl.Text + "', '" 
                        + jtbl.Text + "', '" 
                        + ocb.SelectedValue + "', '" 
                        + hcb.SelectedValue + "', '" 
                        + icb.SelectedValue + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saqlandi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void Reset()
        {
            itbl.Text = "";
            ftbl.Text = "";
            oitbl.Text = "";
            jtbl.Text = "";
            ocb.SelectedIndex = -1;
            hcb.SelectedIndex = -1;
            icb.SelectedIndex = -1;
        }

        private void DeleteBtn()
        {
            if (key == 0)
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Abiturient where AbiturientId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O'chirildi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void UpdateBtn()
        {
            if (itbl.Text == "" || ftbl.Text == "" || oitbl.Text == "" || jtbl.Text == "" || ocb.SelectedIndex == -1 || hcb.SelectedIndex == -1 || icb.SelectedIndex == -1)
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Abiturient set Ismi='" 
                        + itbl.Text + "', Familiyasi='" 
                        + ftbl.Text + "', OtasiningIsmi='" 
                        + oitbl.Text + "', JSHSHIR=" 
                        + jtbl.Text + ", OliygohId=" 
                        + ocb.SelectedValue + ", HududId=" 
                        + hcb.SelectedValue + ", ImtihonId=" 
                        + icb.SelectedValue + "where AbiturientId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yangilandi");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Abiturient ";
            query += "WHERE AbiturientId LIKE '%' + @param + '%' ";
            query += "OR Ismi LIKE '%' + @param + '%' ";
            query += "OR Familiyasi LIKE '%' + @param + '%' ";
            query += "OR OtasiningIsmi LIKE '%' + @param + '%' ";
            query += "OR JSHSHIR LIKE '%' + @param + '%' ";
            query += "OR OliygohId LIKE '%' + @param + '%'";
            query += "OR HududId LIKE '%' + @param + '%'";
            query += "OR ImtihonId LIKE '%' + @param + '%'";
            string con = "Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", stbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void GetOliy()
        {
            SqlConnection cn = new("Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False");
            cn.Open();
            SqlCommand cmd = new("select * from Oliygoh", cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new();
            dt.Columns.Add("OliygohId", typeof(int));
            dt.Load(rdr);
            ocb.DisplayMember = "OliygohNomi";
            ocb.ValueMember = "OliygohId";
            ocb.DataSource = dt;
            cn.Close();
        }

        private void GetHudud()
        {
            SqlConnection cn = new("Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False");
            cn.Open();
            SqlCommand cmd = new("select * from Hudud", cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new();
            dt.Columns.Add("HududId", typeof(int));
            dt.Load(rdr);
            hcb.DisplayMember = "HududNomi";
            hcb.ValueMember = "HududId";
            hcb.DataSource = dt;
            cn.Close();
        }

        private void GetImtihon()
        {
            SqlConnection cn = new("Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False");
            cn.Open();
            SqlCommand cmd = new("select * from Imtihon", cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new();
            dt.Columns.Add("ImtihonId", typeof(int));
            dt.Load(rdr);
            icb.DisplayMember = "ImtihonNomi";
            icb.ValueMember = "ImtihonId";
            icb.DataSource = dt;
            cn.Close();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itbl.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ftbl.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            oitbl.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            jtbl.Text = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            ocb.SelectedValue = DGV.Rows[e.RowIndex].Cells[5].Value;
            hcb.SelectedValue = DGV.Rows[e.RowIndex].Cells[6].Value;
            icb.SelectedValue = DGV.Rows[e.RowIndex].Cells[7].Value;
            if (itbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Restore()
        {
            stbl.Text = "";
            Populate();
            Con.Close();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void ybtn_Click(object sender, EventArgs e)
        {
            UpdateBtn();
        }

        private void obtn_Click(object sender, EventArgs e)
        {
            DeleteBtn();
        }

        private void tbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void qbtn_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void chbtn_Click(object sender, EventArgs e)
        {
            Login l = new();
            l.Show();
            this.Hide();
        }
    }
}