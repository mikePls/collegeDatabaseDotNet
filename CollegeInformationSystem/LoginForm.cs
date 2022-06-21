using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class LoginForm : Form
    {
        QueryHelper queryHelper;
        bool validated = false;

        public LoginForm()
        {
            InitializeComponent();
            queryHelper = QueryHelper.GetInstance;
        }

        /// <summary>
        /// Ok Button handler; Retrieves username and password
        /// parameters from controls and sends them to sqlManager
        /// for validation. If correct, loads main UI form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (queryHelper.ValidateLogin(UsernameBox.Text, PasswordBox.Text))
            {
                validated = true;
                this.Close();
            }
            else
            {
                loginInvalid.Visible = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(!validated)
            {
                MessageBox.Show("Login details are required in order to proceed. " +
                    "This application will now close.", "Login required", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                System.Environment.Exit(1);
                
            }

        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SubmitBtn_Click(sender, e);
            }
        }
    }
}
