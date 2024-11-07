using RegisterApplication.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApplication
{
    public partial class Dashboard : Form
    {
        Staff loginedStaff = new Staff();
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }
        public Dashboard(RegisterApplication.objects.Staff loginStaff)
        {
            InitializeComponent();
            EnterFullScreenMode(this);
            welcomeMessageLabel.Text = "Hello, " + loginStaff.Name;

            loginedStaff = loginStaff;

            if(loginStaff.TypeStaff == "Manager")
            {
                managerButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register form = new Register(managerButton.Enabled, loginedStaff.Name);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeaveFullScreenMode(this);
            this.Close();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagerDashboard form = new ManagerDashboard();
            form.Show();
        }
    }
}
