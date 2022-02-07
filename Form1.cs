using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private static Form1 obj;
        private object lblUserNameWarning;
        private object lblPasswordWarning;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == String.Empty)
            {
                lblUserNameWarning.Visible = true;
            }
            else if(!Regex.Match(txtUserName.Text,"^[a-z0-5]*$").Success)
            {
                MessageBox.Show("IT SHOULD NOT ALLOW NUMBERS");
                txtUserName.Focus();
            }
            else if(txtPassword.Text=="admin")
            {
                lblUserNameWarning.Visible = false;
                lblPasswordWarning.Visible = false;
                this.Hide();
                Form1.obj = new Form1();
                obj.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
