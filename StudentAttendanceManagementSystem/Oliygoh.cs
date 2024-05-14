using BookStoreManagmentSystem;
using System.Data;
using System.Data.SqlClient;

namespace StudentAttendanceManagementSystem
{
    public partial class Oliygoh : Form
    {
        public Oliygoh()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new("Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Oliygoh";
                SqlDataAdapter sda = new(query, Con);
                SqlCommandBuilder builder = new(sda);
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

        private void Reset()
        {
            ittbl.Text = "";
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Oliygoh ";
            query += "WHERE OliygohId LIKE '%' + @param + '%' ";
            query += "OR OliygohNomi LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=ApplicantAttendance_DB;Integrated Security=True;Encrypt=False";

            using SqlConnection conn = new(con);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@param", stbl.Text);
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);
            DGV.DataSource = dt;
            return dt;
        }

        private void Save()
        {
            if (ittbl.Text == "")
            {
                MessageBox.Show("Xato Ma'lumotlar!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Oliygoh values('" + ittbl.Text + "')";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saqlandi!");
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

        private void UpdateCategory()
        {
            if (ittbl.Text == "")
            {
                MessageBox.Show("Xato Ma'lumotlar!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Oliygoh set OliygohNomi='" + ittbl.Text + "' where OliygohId=" + key + ";";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yangilandi!");
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

        private void Delete()
        {
            if (key == 0)
            {
                MessageBox.Show("Xato Ma'lumotlar!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Oliygoh where OliygohID=" + key + ";";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O'chirildi!");
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

        private void RestoreFilter()
        {
            stbl.Text = "";
            Populate();
            Con.Close();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void hlbl_Click_1(object sender, EventArgs e)
        {
            Hudud h = new();
            h.Show();
            this.Hide();
        }

        private void ybtn_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }

        private void obtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void qbtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ittbl.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (ittbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void ilbl_Click(object sender, EventArgs e)
        {
            Imtihon h = new();
            h.Show();
            this.Hide();
        }

        private void chlbl_Click(object sender, EventArgs e)
        {
            Login h = new();
            h.Show();
            this.Hide();
        }
    }
}
