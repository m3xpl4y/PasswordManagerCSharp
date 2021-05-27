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
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "data.txt");

            List<PasswortListUI> passwortLists = new List<PasswortListUI>();
            List<EntryData> entries = new List<EntryData>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] listEntries = line.Split(',');
                EntryData ed = new EntryData();
                ed.ID = listEntries[0];
                ed.Title = listEntries[1];
                ed.Username = listEntries[2];
                ed.Password = listEntries[3];
                ed.Website = listEntries[4];
                entries.Add(ed);
            }

            foreach (var entry in entries)
            {
                PasswortListUI plu = new PasswortListUI();
                plu.ID = entry.ID;
                plu.Title = entry.Title;
                plu.Username = entry.Username;
                plu.Password = entry.Password;
                plu.Website = entry.Website;
                passwortLists.Add(plu);
            }

            //lines.Add("2,Facebook,max,654321,www.facebook.com");
            //File.WriteAllLines(filePath, lines);


            foreach (var item in passwortLists)
            {
                flPanel.Controls.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            AddPassword ap = new AddPassword();
            flPanel.Controls.Add(ap);
        }
    }
}
