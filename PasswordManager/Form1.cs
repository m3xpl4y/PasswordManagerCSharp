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
    public partial class Form1 : Form
    {
        private List<PasswortListUI> passwortListUIs;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //PasswortListUI listUI = new PasswortListUI();
            //passwortListUIs.Add(listUI);
            //foreach(PasswortListUI items in passwortListUIs)
            //{
            //    pnControl.Controls.Add(items);
            //}
            pnControl.Controls.Add(new PasswortListUI());
        }
    }
}
