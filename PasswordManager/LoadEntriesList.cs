using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class LoadEntriesList
    {
        List<PasswortListUI> passwortLists = new List<PasswortListUI>();
        LoadPasswordList lpl = new LoadPasswordList();

        public List<PasswortListUI> passwortListUIs(List<EntryData> entryDatas)
        {        
            entryDatas = lpl.EntryDataList();
            foreach (var entry in entryDatas)
            {
                PasswortListUI plu = new PasswortListUI();
                plu.ID = entry.ID;
                plu.Title = entry.Title;
                plu.Username = entry.Username;
                plu.Password = entry.Password;
                plu.Website = entry.Website;
                passwortLists.Add(plu);
            }
            return passwortLists;
        }
    }
}
