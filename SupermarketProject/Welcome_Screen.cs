using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketProject
{
    public partial class Welcome_Screen : Form
    {
        public Welcome_Screen()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint +=1;
            myProgress.Value = startPoint;
            if(myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                Login_Screen loginForm = new Login_Screen();
                this.Hide();
                loginForm.Show();
            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
