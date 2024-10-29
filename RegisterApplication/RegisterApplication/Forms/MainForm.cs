using RegisterApplication.DAO;
using RegisterApplication.objects;

namespace RegisterApplication
{
    public partial class MainForm : Form
    {
        StaffDAO staffDAO = new StaffDAO();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (staffDAO.doesStaffExist(usernameTextBox.Text, passwordTextBox.Text))
            {

                Staff loginStaff = staffDAO.getStaffByName(usernameTextBox.Text);
                Dashboard form = new Dashboard(loginStaff);
                form.Show();

            }
        }



    }
}
