using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    class LoadPasswordList
    {
        List<string> lines = File.ReadAllLines(EnvironmentPath.FilePath).ToList();
        List<EntryData> entries = new List<EntryData>();

        public List<EntryData> EntryDataList()
        {                

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
            return entries;
        }
    }
}
