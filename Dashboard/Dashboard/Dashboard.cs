using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : Form
    {
        protected User user;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.Login form1 = new Login.Login();
            this.Hide();
            form1.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                lblName.Text = "Welcome, " + user.Name;
            }
        }
    }
}
