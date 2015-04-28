using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace serverConsole
{
    
    class chatDbSql
    {
        public string connString;
        public string query;
        public OleDbCommandBuilder cBuilder;
        public OleDbDataAdapter dAdapter;
        public DataTable dTable;
        public DataView dView;
        public OleDbCommand cmd;

        public void dbQuerry()
        {
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Zagy\\Documents\\Visual Studio 2013\\Projects\\serverConsole\\serverConsole\\chatDb.accdb";
            dTable = new DataTable();
            dView = dTable.DefaultView;
        }
    }
}
