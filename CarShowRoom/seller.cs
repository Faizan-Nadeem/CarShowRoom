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
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSeller();
        }
        Functions Con;
        private void ShowSeller()
        {
            string Query = "select * from SellerTBL";
            SellerDGV.DataSource = Con.GetData(Query);
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            if(SnameTB.Text == "" || PhoneTB.Text == "" || PasswordTB.Text == "" || GenCB.SelectedIndex == -1)
            {
                MessageBox.Show("Data Missing!!!");
            }else
            {
                try
                {
                    string Sname = SnameTB.Text;
                    string Sphone = PhoneTB.Text;
                    string SGen = GenCB.SelectedIndex.ToString();
                    string Spassword = PasswordTB.Text;
                    string Query = "insert into SellerTBL values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Sname, Sphone, DOBTB.Value.Date.ToString(), SGen, Spassword);
                    Con.SetData(Query);
                    ShowSeller();
                    SnameTB.Text = "";
                    PhoneTB.Text = "";
                    PasswordTB.Text = "";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
