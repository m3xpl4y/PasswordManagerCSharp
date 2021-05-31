using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainWindow : Form
    {
        

        public MainWindow()
        {
            InitializeComponent();
            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear(); // Neues Passwort
            AddPassword ap = new AddPassword();
            flPanel.Controls.Add(ap);
        }

        private void neuesPasswortHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            AddPassword ap = new AddPassword();
            flPanel.Controls.Add(ap);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadList(); //Meine Passwörter
        }
        private void LoadList()
        {
            flPanel.Controls.Clear();
            
            LoadPasswordList lpl = new LoadPasswordList();
            List<EntryData> entries = lpl.EntryDataList();

            LoadEntriesList lel = new LoadEntriesList();
            List<PasswortListUI> passwortLists = lel.passwortListUIs(entries);
            foreach (var item in passwortLists)
            {
                flPanel.Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
        }
    }
}
