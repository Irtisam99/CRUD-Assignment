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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=IRTISAM;Initial Catalog=CRUDdb;Persist Security Info=True;User ID=sa;Password=admin99;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand command = new SqlCommand("Insert into GYM1 values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + (comboBox1.Text) + "',getdate(),getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();

            BindData();
        
        }

        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from GYM1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update GYM1 set MemberName='" + textBox2.Text + "',Age='" + textBox3.Text + "', Gender='" + comboBox1.Text + "',UpdateDate= '"+DateTime.Parse(dateTimePicker1.Text)+"' where MemberID= '"+int.Parse(textBox1.Text)+" ' ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated");
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete GYM1 where MemberID= '" + int.Parse(textBox1.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put Member ID " );
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from GYM1 where MemberID= '"+int.Parse(textBox1.Text)+"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
