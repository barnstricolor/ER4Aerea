using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ER4Aerea
{
    class Bd
    {
        public static OleDbConnection ObterConexao(String user,String pass)
        {
            string strConexao = "Provider=MSDAORA;Data Source=xe;Persist Security Info=True;User Id=" + user + ";Password=" + pass + ";";
            OleDbConnection conn;
            //return new OracleConnection(strConexao);
            conn = new OleDbConnection();
            conn.ConnectionString = strConexao;
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
