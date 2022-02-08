using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loginMySql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnRajout_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=mysql;port=3306;password=root"); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into information(name) values('" +Name);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Name = string.Empty;
            
            con.Close();
            MessageBox.Show("Successfully Added", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
