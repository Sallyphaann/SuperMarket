using BusinessLogic;
using DataAccessLayer;

namespace Synthesis_assignment
{
    public partial class LoginForm : Form
    {
        UserAdministration userAdministration;
       

        UserDAL userDal;
        public LoginForm()
        {
            InitializeComponent();
            userDal = new UserDAL();
            userAdministration = new UserAdministration(userDal);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        // Using to exit from the appication
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you wat exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = (tbUserName.Text).ToLower(); // using to upper username , it will login even the user enter the lower case or upper case
                string password = tbPassword.Text;
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    if (userAdministration.CanLogin(username, password)) 
                    { 
                        //int userid = userAdministration.Getid(username);
                        this.Hide();
                        Main main = new Main();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show(" Login faied");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill information");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}