using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace QueryTrans
{
    public partial class Sql_to_Excel : Form
    {
        public Sql_to_Excel()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Query_btn_Click(object sender, EventArgs e)
        {
            string connect = "Server=localhost;Database=TRANS;Trusted_Connection=True;";
            string query = cmd_tb.Text.Trim();
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection sqlCon = new SqlConnection(connect))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                // Hiển thị vào DataGridView
                result_dgv.DataSource = dataTable;
                result_dgv.AutoResizeColumns(); // Tự động điều chỉnh cột
                result_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
