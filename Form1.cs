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
using System.Drawing.Drawing2D;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.product_table' table. You can move, or remove it, as needed.
            this.product_tableTableAdapter.Fill(this.masterDataSet.product_table);

            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, button1.Width - 25, button1.Height - 15);
            button1.Region = new Region(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-NC3ESRI\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqd = new SqlDataAdapter("select * from product_table;", cnn);
            DataTable dtbl = new DataTable();
            sqd.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void round1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundbtn1_Click(object sender, EventArgs e)
        {

        }
    }
}
