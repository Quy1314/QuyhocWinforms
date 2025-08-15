using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QueryTrans
{
    public partial class Sql_to_XML : Form
    {
        public Sql_to_XML()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "Server=localhost;Database=TRANS;Trusted_Connection=True;";
            DataTable dt = new DataTable();
            string query = cmd_tb.Text;
            string filepath = @"C:\Users\Hoang Quy\Downloads\data.XML";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                using(SqlCommand cmd= new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            dt.TableName = "KHACHHANG";
            using(FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
            {
                dt.WriteXml(fs, XmlWriteMode.WriteSchema);
            }

            using(StreamReader sr = new StreamReader(filepath))
            {
                result_tb.Text=sr.ReadToEnd(); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
