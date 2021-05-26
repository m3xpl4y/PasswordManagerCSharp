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
        private List<PasswortListUI> passwortLists = new List<PasswortListUI>();

        public Form1()
        {
            InitializeComponent();            
            
            var plu = new PasswortListUI();
            plu.ID = "11";
            plu.Password = "max";
            plu.Username = "Maximilian";
            plu.Title = "keine Ahnung";
            plu.Website = "www.nichts.com";            
            passwortLists.Add(plu);            
            plu.Dock = DockStyle.Top;

            var plu2 = new PasswortListUI();
            plu2.ID = "12";
            plu2.Username = "Angi";
            plu2.Password = "123456";
            plu2.Title = "TestTitle";
            plu2.Website = "www.test.at";
            passwortLists.Add(plu2);
            plu2.Dock = DockStyle.Top;

            var plu3 = new PasswortListUI();
            plu3.ID = "13";
            plu3.Username = "Angilca";
            plu3.Password = "123456134";
            plu3.Title = "TestTitle..";
            plu3.Website = "www.test.com";
            passwortLists.Add(plu3);
            plu2.Dock = DockStyle.Top;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in passwortLists)
            {
                flPanel.Controls.Add(item);
            }

        }
    }
}
