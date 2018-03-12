using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;

namespace VWMS.CommonClass
{
    class DataCon
    {
        public OleDbConnection getCon()
        {
            string strDPath = System.Windows.Forms.Application.StartupPath;
            string strDataSource = "Provider=Microsoft.Jet.OLEDB.4.0;DataSource="
                + strDPath.Substring(0,strDPath.LastIndexOf(@"\")).Substring(0,strDPath.Substring(0,
                strDPath.LastIndexOf(@"\")).LastIndexOf(@"\"))+@"\DataBase\db_VWMS.mdb";
            OleDbConnection oledbCon = new OleDbConnection(strDataSource);
            return oledbCon;
        }
    }
}
