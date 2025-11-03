using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowRoom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || passwordTb.Text == "") 
            {
                MessageBox.Show("Missing data!!");
            }else
            {
                if (UnameTb.Text == "Admin" || passwordTb.Text == "Admin")
                {
                    MessageBox.Show("");
                    seller Obj = new seller();
                    Obj.Show();
                    this.Hide();

                }
            }
        }
    }
}
