using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;
using System.Data;

namespace VWMS.CommonClass
{
    class DataOperate
    {
        DataCon datacon = new DataCon();
        OleDbConnection oledbcon;
        OleDbCommand oledbcmd;
        OleDbDataAdapter oledbda;
        DataSet ds;

        public void getCmd(string strCon)
        {
            oledbcon = datacon.getCon();
            oledbcmd = new OleDbCommand(strCon, oledbcon);
            oledbcon.Open();
            oledbcmd.ExecuteNonQuery();
            oledbcon.Close();
        }
        public DataSet getDs(string strCon,string tbname)
        {
            oledbcon = datacon.getCon();
            oledbda = new OleDbDataAdapter(strCon, oledbcon);
            ds = new DataSet();
            oledbda.Fill(ds, tbname);
            return ds;
        }
    }
}
