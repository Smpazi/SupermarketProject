using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketProject
{
    public partial class Catergory_Screen : Form
    {
        public Catergory_Screen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lomie\Documents\SupermarketDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTable values("+ CategoryIdTxt.Text +",'"+ CategoryNameTxt.Text +"','"+ CategoryDescriptionTxt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully");
                Con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
