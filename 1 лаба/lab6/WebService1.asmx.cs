using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;


namespace lab6
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet Method1()
        {
            string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("Northwind1.mdb") + ";Persist Security Info=False";
            string z = "select * from Клиенты";
            System.Data.OleDb.OleDbConnection olcon = new System.Data.OleDb.OleDbConnection(s);
            System.Data.OleDb.OleDbCommand olcom = new System.Data.OleDb.OleDbCommand(z, olcon);
            System.Data.OleDb.OleDbDataAdapter DA = new System.Data.OleDb.OleDbDataAdapter(olcom);
            System.Data.DataSet DS = new System.Data.DataSet();
            DA.Fill(DS);
         
            return DS;

        }
    }
}
