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
    public partial class AddPassword : UserControl
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = lastId();
            List<string> output = new List<string>();
            var ed = new EntryData();

            ed.ID = id.ToString();
            ed.Title = txtTitle.Text;
            ed.Username = txtUsername.Text;
            ed.Password = txtPassword.Text;
            ed.Website = txtWebsite.Text;
            
            string entry = $"{ed.ID},{ed.Title},{ed.Username},{ed.Password},{ed.Website}";
            
            output.Add(entry);

            File.AppendAllLines(EnvironmentPath.FilePath, output);

            #region CLEAR TEXT FIELDS
            txtTitle.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtWebsite.Text = "";
            #endregion
            GetLayoutPanel().Controls.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtWebsite.Text = "";
        }
        private int lastId()
        {
            int id = 0;
            List<string> lines = File.ReadAllLines(EnvironmentPath.FilePath).ToList();
            foreach (var line in lines)
            {
                string[] listEntries = line.Split(',');
                EntryData ed = new EntryData();
                ed.ID = listEntries[0];
                lblID.Text = ed.ID;
                id = Int32.Parse(ed.ID);
            }
            id++;
            return id;
        }
        private FlowLayoutPanel GetLayoutPanel()
        {
            FlowLayoutPanel flp = this.Parent as FlowLayoutPanel;
            return flp;
        }
    }
}
