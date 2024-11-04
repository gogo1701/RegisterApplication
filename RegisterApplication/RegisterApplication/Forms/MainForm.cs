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
            if (staffDAO.doesStaffExist(usernameTextBox.Text) && staffDAO.checkPassword(usernameTextBox.Text, passwordTextBox.Text)){ 
            
                Staff loginStaff = staffDAO.getStaffByName(usernameTextBox.Text);
                Dashboard form = new Dashboard(loginStaff);
                form.Show();
            }
            else
            {
                MessageBox.Show("The user does not exist in the database. Make sure the username and password is correct!");
            }
        }
    }
}
