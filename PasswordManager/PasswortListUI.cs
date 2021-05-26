using System.Windows.Forms;

namespace PasswordManager
{
    public partial class PasswortListUI : UserControl
    {
        public string ID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        public string Title
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Website
        {
            get { return txtWebsite.Text; }
            set { txtWebsite.Text = value; }
        }
        
        public PasswortListUI()
        {
            InitializeComponent();
        }
    }
}
