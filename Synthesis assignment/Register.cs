using BusinessLogic;
using BusinessLogic.Entities;
using DataAccessLayer;
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

namespace Synthesis_assignment
{
    public partial class Register : Form
    {
        UserAdministration userAdministration;
        UserDAL newUser;
        public Register()
        {
            InitializeComponent();
            newUser = new UserDAL();
            userAdministration = new UserAdministration(newUser);
        }

        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            // to hide the password
            if (cbShowpassword.Checked)
            {
                
                tbRpassword.UseSystemPasswordChar = false;
                tbRpassword1.UseSystemPasswordChar = false;
            }
            else
            {
                tbRpassword.UseSystemPasswordChar = true;
                tbRpassword1.UseSystemPasswordChar = true;
            }
        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you wat exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRSubmit_Click(object sender, EventArgs e)
        {
            // using this to register for admin in desktop application 
            try
            {
                string salt = Guid.NewGuid().ToString();
                string password = tbRpassword.Text;
                string hashedPassword = PasswordHasher.sha256_hash(password + salt);
                string username = (tbRusername.Text).ToLower();


                if (!string.IsNullOrEmpty(tbRFname.Text) && !string.IsNullOrEmpty(tbRLname.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbAddress.Text) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(tbRpassword.Text) && !string.IsNullOrEmpty(tbRpassword1.Text) && cbxPossiton.SelectedIndex != -1)
                {
                    if (Checkpassword())
                    {
                        if (IsValidEmail(tbEmail.Text))
                        {
                            Admin admin = new Admin(tbRFname.Text, tbRLname.Text, tbEmail.Text, tbAddress.Text, tbRusername.Text, hashedPassword, salt, cbxPossiton.Text);
                            if (userAdministration.CheckUserNameExistence(admin))
                            {
                                MessageBox.Show("Sorry this username was exit");
                            }
                            if (userAdministration.CheckEmailUser(admin))
                            {
                                MessageBox.Show("Sorry this email was exit");
                            }
                            else
                            {
                                userAdministration.AddAdmin(admin);
                                MessageBox.Show("You are Success");
                                //ClearTextbox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("this is invaild email");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("your password should be the same ");
                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("please fill all the infomation");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // check if the password is the same 
        public bool Checkpassword()
        {
            try
            {
                if (tbRpassword.Text == tbRpassword1.Text)
                {
                    return true;
                }
            }
            catch(Exception ex) 
            { 
                
                throw new Exception(ex.Message);
            }
            return false;

        }
        // check if the email is correct type
        public static bool IsValidEmail(string email)
        {

            Regex emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailregex.IsMatch(email);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
