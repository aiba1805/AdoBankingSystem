using AdoBankingSystem.ClientUI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoBankingSystem.ClientUI.Forms
{
    public partial class SignInForm : BaseForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            if (!(string.IsNullOrEmpty(email) &&
            string.IsNullOrEmpty(password)))
            {
                _applicationClientService.SignInToApplication(email, password);
            }
        }
    }
}
