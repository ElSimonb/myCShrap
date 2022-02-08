using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loginMySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=mysql;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                Form2 f = new Form2();
                f.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
