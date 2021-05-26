using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class PasswortListUI : UserControl
    {
        public PasswortListUI()
        {
            InitializeComponent();
            GetSetData gsd = new GetSetData();
            lblID.Text = gsd.ID.ToString();
            txtTitle.Text = gsd.Title;
            txtUsername.Text = gsd.Username;
            txtPassword.Text = gsd.Password;
            txtWebsite.Text = gsd.Website;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
